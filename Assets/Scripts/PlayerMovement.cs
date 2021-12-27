using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardforce = 500f;
    public float sideforce = 50f;
    public GameManager GameManager;
	// Use this for initialization
	void Start ()
    {
        	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardforce*Time.deltaTime );
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideforce  * Time.deltaTime, 0, 0,ForceMode.VelocityChange );
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0,50000* Time.deltaTime, 0);
        }
        if(rb.position.y < -2)
        {
            GameManager.EndGame();
        }
    }
}
