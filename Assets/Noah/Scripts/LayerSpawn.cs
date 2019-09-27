using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSpawn : MonoBehaviour
{
    public GameObject brick;
    public uint bricksPerLayer;
    
    // Start is called before the first frame update
    void Start()
    {
        // Calculate radius
        float r = (bricksPerLayer / (2 * Mathf.Sin((180f / brick.transform.localScale.x) * Mathf.Deg2Rad)));

        // Instantiate Bricks
        for(int i =0; i < bricksPerLayer; i++)
        {
            // Calculate position
            Vector3 pos = new Vector3(r * Mathf.Cos((i * 2 * Mathf.PI) / bricksPerLayer), 0.5f, r * Mathf.Sin((i * 2 * Mathf.PI) / bricksPerLayer));

            // Calculate rotation
            Quaternion rot = Quaternion.AngleAxis((360 / bricksPerLayer * -i) + 90, Vector3.up);

            // Instantiate Brick with rotation and position with this object as the parent
            GameObject hold = Instantiate(brick, transform, false);

            hold.transform.localPosition = pos;
            hold.transform.localRotation = rot;
        }
    }
}
