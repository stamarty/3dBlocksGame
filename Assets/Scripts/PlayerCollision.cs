using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        //checks for collision with blocks and triggers "death" if true.
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
