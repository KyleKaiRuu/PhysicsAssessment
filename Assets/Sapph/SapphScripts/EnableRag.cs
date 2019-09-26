using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableRag : MonoBehaviour
{
    public List<Rigidbody> rigidbodies;

    private void OnTriggerEnter(Collider other)
    {
        if (/*other.gameObject.name == "Cube" || other.gameObject.name.Contains("p3vr")*/!other.gameObject.transform.IsChildOf(gameObject.transform) && other.gameObject.name != "Plane")
        {
            foreach (Rigidbody rigi in rigidbodies)
            {
                rigi.isKinematic = false;
            }
        }
    }
}