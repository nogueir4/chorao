﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {
    public Rigidbody rb;
    
    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
 
    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if( Input.GetKey("d")){
            rb.AddForce(sidewaysForce, 0, 0);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce);
        }

     
    }
}
