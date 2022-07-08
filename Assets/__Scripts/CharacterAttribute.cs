using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="CharacterAttribute", menuName="Character")]
public class CharacterAttribute : ScriptableObject
{
    //Variables for info
    public string Name;
    public string Description;
    public float Speed;
    public float Strength;
    public float Health;
    public GameObject character;

    //get method for speed
    public string getSpeed()
    {
        return "Speed: " + Speed;
    }
    //get method for strength
    public string getStrength()
    {
        return "Strength: " + Strength;
    }
    //get method for health
    public string getHealth()
    {
        return "Health: " + Health;
    }






}
