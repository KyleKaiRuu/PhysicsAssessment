using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableRag : MonoBehaviour
{
    public List<Rigidbody> rigidbodies;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Platform")
        {
            Debug.Log(other.gameObject.name);
            foreach (Rigidbody rigi in rigidbodies)
            {
                rigi.isKinematic = false;
            }
        }
    }
}