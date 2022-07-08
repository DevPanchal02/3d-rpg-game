using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDrop : MonoBehaviour
{
    public GameObject playerCamera; //this is a reference to the main camera (drag & drop)
    public GameObject playerHand;
    public GameObject weapon;
    public GameObject character;

    [Header("Settings")]
    public int totalThrows;
    public float throwCooldown;

    [Header("Throwing")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float throwUpwardForce;

    bool readyToThrow;
 
 
    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo; //a structure to hold hit information (gameobject we hit, position of the "impact" etc.)
        Ray r = new Ray(playerCamera.transform.position, playerCamera.transform.forward); //A ray starting from the camera, going forward
 
        //if we hit something
        if(Physics.Raycast(r, out hitInfo))
        {
            //if it is tagged as a weapon
            if (hitInfo.transform.CompareTag("Weapons"))
            {
                //if the user presses F
                if (Input.GetKeyDown(KeyCode.F))
                {   
                    weapon = hitInfo.transform.gameObject;
                    weapon.gameObject.transform.parent = playerHand.transform;
                    weapon.gameObject.transform.localPosition = new Vector3(0,0,0);
                    weapon.gameObject.transform.localRotation = Quaternion.identity;
                    weapon.GetComponent<Rigidbody>().useGravity = false; //"disabling" the rigidbody (it's still active but gravity won't apply to it.
                    weapon.GetComponent<Collider>().isTrigger = true; //disabling the collider.
                }
            }

            if(Input.GetKeyDown(KeyCode.E))
            {

            weapon.transform.parent = null;
            weapon.GetComponent<Rigidbody>().useGravity = true; 
            weapon.GetComponent<Collider>().isTrigger = false; 
            Throw();
            //Vector3 pushObj = hitInfo.transform.position - playerCamera.transform.position;
            //weapon.GetComponent<Rigidbody>().AddForceAtPosition(pushObj.normalized, pushObj, ForceMode.Impulse);
            //hitInfo.localPosition = Vector3.Lerp(hitInfo.localPosition, playerHand.transform.localPosition, 1f);
            
        }
        }

        
    }

    private void Throw()
    {
        readyToThrow = false;

        // get rigidbody component
        Rigidbody projectileRb = weapon.GetComponent<Rigidbody>();

        // calculate direction
        Vector3 forceDirection = playerCamera.transform.forward;

        RaycastHit hit;

        if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, 10f))
        {
            forceDirection = (hit.point - weapon.transform.position).normalized;
        }

        // add force
        Vector3 forceToAdd = forceDirection * throwForce + transform.up * throwUpwardForce;

        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

        totalThrows--;
        character.gameObject.GetComponent<SwordAttack>().heavyAttackS = 5f;

    }
}
