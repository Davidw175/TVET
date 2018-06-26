using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public int x, y, z;
    public Text ScoreR;
    public int Score;

    /*This function detects if the player has collided witht the outer invisible borders which will send the player
    back to its' original spawn position as well as adding a point to the score board by replacing the text
    in the score with "score: " + Score which will display the score and the players current score.*/
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Die")
        {
            transform.position = new Vector3(x, y, z);
            Score++;
            ScoreR.text = "Score: " + Score;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }



    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        /*Detects if the player has pressed any of the following keys inorder to peform a action which
         in this case will move the player left and right across the screen as well as boosting the players' speed.*/
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.MovePosition(transform.position + transform.right * -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.MovePosition(transform.position + transform.right * speed);
        }
        if (speed <= 0.15)
        {
            speed = 0.15f;
        }
        /*This if statement will boost the speed of the player when the down arrow is pressed down. The boost actually is just adding
        and multiplying the players speed, almost like a push.*/
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 30.0f);
        }
    }
}