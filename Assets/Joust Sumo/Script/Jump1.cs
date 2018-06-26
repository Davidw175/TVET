using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump1 : MonoBehaviour
{

    public bool isGrounded;
    public float jump;
    /*Detect if there is collision between the "Arena"(floor) and the player*/
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Arena")
        {
           isGrounded = true;
        }


    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*If the collision is true, this jump command will be able to run, the player is shot up into
         * the air and also in the opposite direction of the enemy(towards the outskirts of the arena).*/
        if (isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                GetComponent<Rigidbody>().velocity = Vector3.up * jump;
                this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 300.0f);

                isGrounded = false;
                /*This sets the isGrounded variable to false in order to stop the player from being
                able to jump infinitely and exploiting this error*/
            }
        }
    }

}
