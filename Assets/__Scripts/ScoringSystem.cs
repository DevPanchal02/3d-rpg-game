using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ScoringSystem
public class ScoringSystem : MonoBehaviour
{
    
    //Ontrigger enter to destroy gameobject and add coins
    void OnTriggerEnter(Collider other)
    {
        ScoreTextScript.coinAmount += 1;
            Destroy(gameObject);
        }

    }
