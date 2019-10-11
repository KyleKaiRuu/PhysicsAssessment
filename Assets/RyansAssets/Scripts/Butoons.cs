using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Butoons : MonoBehaviour
{
    public Slider velocitySlider;
    private bool explode = false;
    public GameObject bomb;

    private void Update()
    {
        if (explode)
        {

            //bomb.gameObject.GetComponent<SphereCollider>().radius += 1;
            bomb.transform.localScale += new Vector3(1,1,1);
            Debug.Log("increase");
            //Destroy(bomb, 10);
        
        }
        if (bomb == null)
        {
           explode = false;
        }
    }
    public void ShowTimeTillImpact(Text label)
    {
        label.text = velocitySlider.value.ToString();
    }
    public void Explode(/*GameObject boom*/)
    {
        Instantiate(bomb);
        //bomb = boom;
        //bomb.gameObject.GetComponent<SphereCollider>().radius = 1;
        explode = true;
       
    }
}
