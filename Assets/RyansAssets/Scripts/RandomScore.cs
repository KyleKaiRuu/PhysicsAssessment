using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScore : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 100);
    }

    
}
