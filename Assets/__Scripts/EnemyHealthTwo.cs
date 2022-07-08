using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemy Health script
public class EnemyHealthTwo : EnemyHealth
{

    //overide method
    public override void Update()
    {
        //slider value
        slider.value = CalculateHealth();

        //if statement
        if (health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }
        //checks if value is less then = 0
        if (health <= 0)
        {
            Instantiate(coin, transform.position + new Vector3(-1, 0, -1), new Quaternion());
            Instantiate(coin, transform.position + new Vector3(1, 0, 1), new Quaternion());
            Destroy(gameObject);
            ExperienceScript.experienceAmount = ExperienceScript.experienceAmount + 12;


        }
        //sets health
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
