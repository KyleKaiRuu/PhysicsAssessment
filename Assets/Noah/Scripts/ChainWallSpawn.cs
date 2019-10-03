using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Wall
{
    public uint width;
    public uint height;
    public float spacing;
    public float rotation;
}

public class ChainWallSpawn : MonoBehaviour
{
    public GameObject wallPrefab;
    public Wall[] walls;


    // Start is called before the first frame update
    void Start()
    {
        Transform lastWall = transform;
        for (int i = 0; i < walls.Length; i++)
        {
            GameObject hold = Instantiate(wallPrefab, lastWall, false);
            WallSpawn wallSpawn = hold.GetComponent<WallSpawn>();

            wallSpawn.width = walls[i].width;
            wallSpawn.height = walls[i].height;
            wallSpawn.spacing = walls[i].spacing;
            wallSpawn.anchorIsMid = false;
            hold.transform.localPosition = i == 0 ? Vector3.zero : new Vector3(walls[i].width * 3 + walls[i].spacing * walls[i].width, 0, 0);
            hold.transform.localRotation = Quaternion.AngleAxis(walls[i].rotation, Vector3.up);

            lastWall = hold.transform;
        }
    }
}
