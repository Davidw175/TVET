using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 
[] - Brackets
{} - Braces
() - Parethesis

Clean Code: CTRL + K + D

*/
public class Player : MonoBehaviour
{
    int num = 1;
    public string message = "Hello World!";
    public float moveSpeed = 3f;
    public Rigidbody rigid;
    // Use this for initialization
    void Start()
    {
        print("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        print("░░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄░░░░░░░░░");
        print("░░░░░░░░▄▀░░░░░░░░░░░░▄░░░░░░░▀▄░░░░░░░");
        print("░░░░░░░░█░░▄░░░░▄░░░░░░░░░░░░░░█░░░░░░░");
        print("░░░░░░░░█░░░░░░░░░░░░▄█▄▄░░▄░░░█░▄▄▄░░░");
        print("░▄▄▄▄▄░░█░░░░░░▀░░░░▀█░░▀▄░░░░░█▀▀░██░░");
        print("░██▄▀██▄█░░░▄░░░░░░░██░░░░▀▀▀▀▀░░░░██░░");
        print("░░▀██▄▀██░░░░░░░░▀░██▀░░░░░░░░░░░░░▀██░");
        print("░░░░▀████░▀░░░░▄░░░██░░░▄█░░░░▄░▄█░░██░");
        print("░░░░░░░▀█░░░░▄░░░░░██░░░░▄░░░▄░░▄░░░██░");
        print("░░░░░░░▄█▄░░░░░░░░░░░▀▄░░▀▀▀▀▀▀▀▀░░▄▀░░");
        print("░░░░░░█▀▀█████████▀▀▀▀████████████▀░░░░");
        print("░░░░░░████▀░░███▀░░░░░░▀███░░▀██▀░░░░░░");
        print("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        //transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);


        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(Vector3.forward * speed);
            //print(message);
            //num++;
        }

    }
}


