using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private bool start = false;
    public float explosionForce = 0;
    public float explosionRadius = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            start = true;
            gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, (gameObject.transform.position + new Vector3(1, -5, 0)), explosionRadius);
        }
        if (start)
        {
            //gameObject.transform.position += new Vector3(1, 0, 0);
        }
    }

}
