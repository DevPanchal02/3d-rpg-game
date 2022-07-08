using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Healthbar Controller class
public class HealthBarController : MonoBehaviour
{
    //Public variables
    public Image healthBar;
    public float health;
    public float startHealth;
    public ExperienceScript exp;

    //onTakeDamage method to calculate damaged
    public void onTakeDamage(int damage)
    {
        health = health - damage;
        healthBar.fillAmount = health / startHealth;
    }

    //Player regen hp after getting 3 coins
    private void FixedUpdate()
    {
        if (ScoreTextScript.coinAmount >=3)
        {
            health += 0.02f;
            healthBar.fillAmount = health / startHealth;
        }
    }
}
