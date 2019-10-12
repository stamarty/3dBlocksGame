using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Teaches the camera to follow the player.
    void Update()
    {
        transform.position = player.position + offset;
    }
}
