using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{

    public GameObject towerLayer;
    public uint towerHeight = 1;
    public float towerLayerRotation = 10.0f;
    public uint bricksPerLayer = 8;

    private Quaternion currRotation = Quaternion.identity;
    private Vector3 currPos;


    // Start is called before the first frame update
    void Start()
    {
        currPos = gameObject.transform.position;

        for (int i = 0; i < towerHeight; i++)
        {
            GameObject layer = Instantiate(towerLayer, currPos, currRotation, transform);
            LayerSpawn layerSpawn = layer.GetComponent<LayerSpawn>();
            if (layerSpawn != null)
            {
                layerSpawn.bricksPerLayer = bricksPerLayer;
            }
            currRotation = currRotation * Quaternion.AngleAxis(towerLayerRotation, Vector3.up);
            currPos += new Vector3(0, 1.00f, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
