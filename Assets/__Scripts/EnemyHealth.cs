using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Slider slider;
    public float health;
    public float maxHealth;
    public float healthPercentage;
    public GameObject healthBarUI;

    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    //Update method to update every frame
    public virtual void Update()
    {
        //slider value to calculate health
        slider.value = CalculateHealth();

        //if statement for health
        if (health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }
        //checks if health is less then = 0
        if(health <= 0)
        {
            Instantiate(coin, transform.position, new Quaternion());
            Destroy(gameObject);
            ExperienceScript.experienceAmount = ExperienceScript.experienceAmount + 5;

        }
        //if statement to set health
        if (health > maxHealth)
        {
            health = maxHealth;
        }

    }
    //Calculates health with dmg received
    public void calculateHealth(float damage)
    {
        health -= damage;
    }
    //calculates health percentage
    public float CalculateHealth()
    {
        healthPercentage = health / maxHealth;
        return healthPercentage;
    }
}