using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Variables
    private Transform player;
    private float dist;
    public float moveSpeed;
    public float howClose;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;


    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);

        //If statement to check distance
            if (dist <= howClose)
            {
                transform.LookAt(player);
                GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);
            }
     

        //Add a Melee Attack
        if(dist <= 1.5f)
        {

            //damage

        }
    }
}
