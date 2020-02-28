using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMove movement;
    
    void OnCollisionEnter(Collision colInfo) {
        if (colInfo.collider.tag == "obstacle")
        {
            movement.enabled = false; 
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
