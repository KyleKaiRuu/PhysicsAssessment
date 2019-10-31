using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingBall : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject wreckPrefab;
    public bool active = false;
    private bool spawned = false;
    private GameObject wreckingBall;
  

    // Update is called once per frame
    void Update()
    {
        if (active) 
        {
            if (!spawned)
            {
                wreckingBall = Instantiate(wreckPrefab, spawnPoint.transform);
                spawned = true;
            }
        }
        else
        {
            if (wreckingBall != null)
            {
                Destroy(wreckingBall);
                spawned = false;
            }
        }
    }
    public void drop()
    {
        if (wreckingBall != null)
        {
            wreckingBall.transform.GetChild(wreckingBall.transform.childCount - 1).GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    public void resetBall()
    {
        Destroy(wreckingBall);
        wreckingBall = Instantiate(wreckPrefab, spawnPoint.transform);
    }
}
