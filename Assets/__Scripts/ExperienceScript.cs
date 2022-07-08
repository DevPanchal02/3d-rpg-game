using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExperienceScript : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    public static int experienceAmount;
    Scene currentScene;
    
    void Start()
    {
        text = GetComponent<Text>();
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()

        //If statements to verify experience and to send player to different scene
    {
        text.text = "Experience: " + experienceAmount;

        if(experienceAmount >= 34 && currentScene.name == "Playground")
        {
            SceneManager.LoadScene("Map1Hero");
        }
        else if(experienceAmount >= 34 && currentScene.name == "PlaygroundTwo")
        {
            SceneManager.LoadScene("Map2Hero");
        }
        else if(experienceAmount >= 34 && currentScene.name == "PlaygroundThree")
        {
            SceneManager.LoadScene("Map3Hero");
        }

    }
}
