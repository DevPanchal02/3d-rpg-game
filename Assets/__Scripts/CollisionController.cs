using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//CollisionController Class
public class CollisionController : MonoBehaviour
{
    public HealthBarController healthbar;
    public GameObject DeathScreen;

    //onCollisionEnter Method
    void OnCollisionEnter(Collision collision)
    {
        //Checks for gameObject tag for enemy
        if (collision.gameObject.tag == "Enemy")
        { 
        if (healthbar)
        {
        healthbar.onTakeDamage(10);
        }
}
}
    //void update method to update every frame
    void Update()
    {
        //Destroys gameObject if healthbar == 0
        if (healthbar.health == 0)
        {
            Destroy(gameObject);
            
            

        }
    }
}
