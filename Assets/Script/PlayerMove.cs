using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1000f;
    public float turn = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(0,0,speed * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-turn * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(turn * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
