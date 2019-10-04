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
        }
        else if (num > 50)
        {
            gameObject.GetComponent<MeshRenderer>().material = green;
        }
        else if (num > 25)
        {
            gameObject.GetComponent<MeshRenderer>().material = red;
        }
        
    }
    private void Update()
    {
       
    }

}
