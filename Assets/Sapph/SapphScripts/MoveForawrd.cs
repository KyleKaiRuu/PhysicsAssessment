using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForawrd : MonoBehaviour
{
    public Vector3 forward;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        forward = gameObject.transform.forward;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forward * force);
        }
    }
}
