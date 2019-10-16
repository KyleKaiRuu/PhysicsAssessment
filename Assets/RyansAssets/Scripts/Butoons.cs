using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Butoons : MonoBehaviour
{
    public Slider velocitySlider;
    private bool explode = false;
    public GameObject bomb;
    private GameObject boom;

    private void Update()
    {
        if (boom == null)
        {
           explode = false;
        }
        else if (explode)
        {

            //bomb.gameObject.GetComponent<SphereCollider>().radius += 1;
            boom.transform.localScale +=new Vector3(5,5,5);
            Debug.Log("increase");
            //Destroy(bomb, 10);
       // bomb.gameObject.transform.localScale+= new Vector3(1, 1, 1);
        }
    }
    public void ShowTimeTillImpact(Text label)
    {
        label.text = velocitySlider.value.ToString();
    }
    public void Explode(/*GameObject boom*/)
    {
        Destroy(boom);
        boom = Instantiate(bomb);
        //bomb = boom;
        //bomb.gameObject.GetComponent<SphereCollider>().radius = 1;
        explode = true;
        Destroy(boom, 5);
    }
}
