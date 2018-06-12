using UnityEngine;
using System.Collections;

public class PlayerMovement1 : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + transform.right * -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position + transform.right * speed);
        }
        if (speed <= 0.15)
        {
            speed = 0.15f;
        }
    }
}