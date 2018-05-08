using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public float bulletspeed = 20f;
    public float shootRate = 0.2f;

    private float shootTimer = 0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        shootTimer += Time.deltaTime;
        if (shootTimer >= shootRate)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                shoot();
                shootTimer = 0f;
            }
        }
		
	}

    void shoot()
    {
        GameObject clone = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
        rigid.AddForce(transform.up * bulletspeed, ForceMode2D.Impulse);
    }
}
