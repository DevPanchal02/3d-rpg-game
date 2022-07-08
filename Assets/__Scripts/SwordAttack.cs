using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwordAttack : MonoBehaviour
{
    //Variables 
    CharacterController controller;
    Animator anim;
    public Transform attackPoint;
    //Public float values for damage
    public float attackRange = 0.5f;
    public float lightAttackS = 1f;
    public float heavyAttackS = 8.5f;
    public float lightAttackA = 1.5f;
    public float heavyAttackA = 15f;
    public float lightAttackN = 0.5f;
    public float heavyAttackN = 3f;
    //public variables for layers and game object
    public LayerMask enemyLayers;
    public GameObject characterScripts;
    

    //Start method called at the start of the game
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }
    //gets player input every frame
    private void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        //Checks if Character 1 "Knight" is loaded and loads attack animations for him
        if (SceneManager.GetActiveScene().name == "Playground" || SceneManager.GetActiveScene().name == "Map1Hero")
        {
            //checks if mouse 1 is down
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                //Stores enemies hit in a array
                anim.SetTrigger("Attack1");
                Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies)
                {
                    Debug.Log("light");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(lightAttackS);
                }

            }
            //checks if mouse 2 is down
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {

                anim.SetTrigger("Attack2");
                Collider[] hitEnemies2 = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies2)
                {
                    Debug.Log("heavy");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(heavyAttackS);
                }
            }
        }
        //Checks if Character 2 "Ragnarok" is loaded and loads attack animations for him
        else if (SceneManager.GetActiveScene().name == "PlaygroundTwo" || SceneManager.GetActiveScene().name == "Map2Hero")
        {
            //checks if mouse 1 is down
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                //Stories enemies hit in array
                anim.SetTrigger("axeA1");
                Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies)
                {
                    Debug.Log("light");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(lightAttackA);
                }

            }
            //checks if mouse 2 is down
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {

                anim.SetTrigger("axeA2");
                Collider[] hitEnemies2 = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies2)
                {
                    Debug.Log("heavy");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(heavyAttackA);
                }
            }
        }

        //Checks if Character 3 "Ninja" is loaded and loads attack animations for him
        else if (SceneManager.GetActiveScene().name == "PlaygroundThree" || SceneManager.GetActiveScene().name == "Map3Hero")
        {
            //checks if mouse 1 is down
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                //Stories enemies hit in a array
                anim.SetTrigger("punchA1");
                Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies)
                {
                    Debug.Log("light");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(lightAttackN);
                }

            }
            //checks if mouse 2 is down
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {

                anim.SetTrigger("punchA2");
                Collider[] hitEnemies2 = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider Enemy in hitEnemies2)
                {
                    Debug.Log("heavy");
                    Enemy.gameObject.GetComponent<EnemyHealth>().calculateHealth(heavyAttackN);
                }
            }
        }



    }
    //Draws gizmo for stats
   private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}