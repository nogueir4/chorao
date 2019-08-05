using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penis : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(500, 0, 500);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-500, 0, 500);
        }

    }
}

