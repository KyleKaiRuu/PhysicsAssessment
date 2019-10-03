using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    public GameObject brick;
    public uint width = 5;
    public uint height = 5;
    public float spacing = 0.2f;
    public bool anchorIsMid = true;
    
    // Start is called before the first frame update
    void Start()
    {
        float layerOffset = 0;
        for(int i =0; i < height; i++)
        {
            layerOffset = i % 2 == 0 ? 0.5f + spacing / 2 : -0.5f - spacing / 2;
            for(int j = 0; j < width; j++)
            {
                Vector3 pos = new Vector3(j * (3 + spacing) + (anchorIsMid ? (((float)width - 1) * 3 + (width - 1) * spacing) / 2 * -1 : 1.5f + spacing / 2) + layerOffset, i + 0.5f);

                GameObject hold = Instantiate(brick, transform, false);

                hold.transform.localPosition = pos;
                hold.transform.localRotation = Quaternion.identity;
            }
        }
    }
}
