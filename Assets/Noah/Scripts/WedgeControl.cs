using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WedgeControl : MonoBehaviour
{
    public float Acceleration = 30;
    public float MaxVelocity = 5;

    Rigidbody rb; //this objects Rigidbody

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * Acceleration);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * Acceleration);
        }

        if(rb.velocity.magnitude > MaxVelocity)
        {
            rb.velocity = rb.velocity.normalized * MaxVelocity;
        }
    }
}
