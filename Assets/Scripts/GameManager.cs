using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1;
    public GameObject completeLevelUI;
    
    public void EndGame()
    {
        //looks for "death" of the character and restarts the level if death is true. 
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay );
        }
        
    }

    //method that actually restarts the level on collision or falling off the platform
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
