using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        //once end of level trigger is hit, this moves the scene forward 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

