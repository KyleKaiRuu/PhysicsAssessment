using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text bricksDestroyed;
    private int kills;
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
            kills += collision.gameObject.GetComponent<RandomScore>().num;
            Destroy(collision.gameObject);
        }
    }
}
