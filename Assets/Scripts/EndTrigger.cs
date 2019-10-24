using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    
    void OnTriggerEnter ()
    {
        //tells game manager that the level trigger has been reached.
        gameManager.CompleteLevel();
    }
}
