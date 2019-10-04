using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScore : MonoBehaviour
{
    public float num;
    public Material red;
    public Material green;
    public Material blue;
    private bool set = false;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 100);
        if (num > 75)
        {
            gameObject.GetComponent<MeshRenderer>().material = blue;
            gameObject.GetComponent<Rigidbody>().mass = .4f;
        }
        else if (num > 50)
        {
            gameObject.GetComponent<MeshRenderer>().material = green;
            gameObject.GetComponent<Rigidbody>().mass = .3f;
        }
        else if (num > 25)
        {
            gameObject.GetComponent<MeshRenderer>().material = red;
            gameObject.GetComponent<Rigidbody>().mass = .2f;
        }
        
    }
    private void Update()
    {
       
    }

}
