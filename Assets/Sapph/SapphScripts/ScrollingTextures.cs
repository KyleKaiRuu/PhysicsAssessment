using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingTextures : MonoBehaviour
{
    public int materialIndex = 0;
    public Vector2 uvAnimationRate = new Vector2(1.0f, 0.0f);
    public string textureName = "_MainTex";

    public float multi = 1.5f;

    Vector2 uvOffset = Vector2.zero;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.mainTextureScale = new Vector2(gameObject.transform.localScale.x * multi, gameObject.transform.localScale.z * multi);
        //gameObject.GetComponent<Renderer>().material.SetTextureScale() = new Vector2(gameObject.transform.localScale.x * multi, gameObject.transform.localScale.z * multi);
    }
    void LateUpdate()
    {
        uvOffset += (uvAnimationRate * Time.deltaTime);
        if (gameObject.GetComponent<Renderer>().enabled)
        {
            gameObject.GetComponent<Renderer>().materials[materialIndex].SetTextureOffset(textureName, uvOffset);
        }
    }
}