using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        //used in lieu of quitting the application since this is run in terminal.
        Debug.Log("Quitting!!");
        Application.Quit();
    }
    
}
