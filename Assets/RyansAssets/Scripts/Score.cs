using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text bricksDestroyed;
    public GameObject lavaSplash;
    private int kills;
    private Vector3 splashPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bricksDestroyed.text = kills.ToString();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cannonball")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag != "bottom")
        {
            splashPos = Vector3.zero;
            for(int i = 0; i < collision.contactCount; i++)
            {
                splashPos += collision.contacts[i].point;
            }
            splashPos.y = 0;
            splashPos = splashPos / collision.contactCount;

            Instantiate(lavaSplash, splashPos, Quaternion.identity);

            kills += (int)collision.gameObject.GetComponent<RandomScore>().num;
            Destroy(collision.gameObject);
        }
    }
}
