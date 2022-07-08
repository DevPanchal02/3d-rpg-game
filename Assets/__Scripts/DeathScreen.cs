using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    //Variables
    public GameObject deathScreen;
    public GameObject Character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Finds componet and invokes method
        if (Character.GetComponent<CollisionController>().healthbar.health == 0)
        {
            Invoke("Death", 0.1f);
        }
        
    }
    //Death method to display deathscreen
    void Death()
    {
        deathScreen.SetActive(true);
        Invoke("Restart", 4f);
    }
    //Restart method to restart the scene after death
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        deathScreen.SetActive(false);
    }
}
