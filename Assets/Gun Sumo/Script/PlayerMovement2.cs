using UnityEngine;
using System.Collections;

public class PlayerMovement2 : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        /*float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVertical = Input.GetAxis("Vertical2");

        Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);

        rb.AddForce(movement * speed);*/

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.MovePosition(transform.position + transform.right * -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.MovePosition(transform.position + transform.right * speed);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(transform.position + transform.up * speed);
            //rb.AddForce(transform.position + transform.up * speed);
        }
        if (speed <= 0.15)
        {
            speed = 0.15f;
        }
    }
}