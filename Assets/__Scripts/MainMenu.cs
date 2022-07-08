using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Mainmenu
public class MainMenu : MonoBehaviour
{
    //Plays game
    public void playClick()
    {
        SceneManager.LoadScene("CharacterSelect");
    }

    //Quits game
    public void quitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


}
