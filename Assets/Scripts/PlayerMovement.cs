using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigibody component called "rb"
    public Rigidbody rd;


    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Called "FixedUpdate" because we are messing with physics
    void FixedUpdate()
    {
        // Add a forward force
        rd.AddForce(0, 0, forwardForce * Time.deltaTime);

		if ( Input.GetKey("d") )
		{
            // Add force on the right side
            rd.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

        if (Input.GetKey("a"))
        {
            // Add force to the left side
            rd.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rd.position.y < -1f)
		{
            FindObjectOfType<GameManager>().EndGame();
		}
    }
}
