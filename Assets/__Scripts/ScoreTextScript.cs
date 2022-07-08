using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    //Variables
    Text text;
    public static int coinAmount;

    //Start method called at the start of the game
    void Start()
    {
        text = GetComponent<Text>();
    }
    //Updates coin amount
    void Update()
    {
        text.text = "Gold: " + coinAmount;
    }


}
