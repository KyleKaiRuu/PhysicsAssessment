using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{

    public GameObject towerLayer;
    public uint towerHeight = 1;
    public float towerLayerRotation = 10.0f;
    public uint bricksPerLayer = 8;
    public bool flipLayer = false;

    private Quaternion currRotation = Quaternion.identity;
    private Vector3 currPos;


    // Start is called before the first frame update
    void Start()
    {
        currPos = gameObject.transform.position;

        // Adjust height for flippable layer
        if(flipLayer == true)
        {
            currPos += new Vector3(0, 0.5f, 0);
        }

        for (int i = 0; i < towerHeight; i++)
        {
            GameObject layer = Instantiate(towerLayer, currPos, currRotation, transform);
            // Get LayerSpawn component from new layer object
            LayerSpawn layerSpawn = layer.GetComponent<LayerSpawn>();
            if (layerSpawn != null)
            {
                //set number of bricks to spawn on the new layer
                layerSpawn.bricksPerLayer = bricksPerLayer;
            }

            // Flip every other layer
            if(flipLayer == true && i % 2 == 0)
            {
                layer.transform.localRotation = Quaternion.AngleAxis(180, Vector3.right);
            }

            if (flipLayer == false)
            {
                currRotation = currRotation * Quaternion.AngleAxis(towerLayerRotation, Vector3.up);
            }
            currPos += new Vector3(0, 1.00f, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
