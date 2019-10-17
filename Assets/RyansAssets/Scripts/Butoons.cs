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
    public Toggle cannonToggle;
    public CannonBall cannon;

    private void Update()
    {
        if (boom == null)
        {
           explode = false;
        }
        else if (explode)
        {            
            boom.transform.localScale +=new Vector3(5,5,5);           
        }
    }
    public void ShowTimeTillImpact(Text label)
    {
        label.text = velocitySlider.value.ToString();
    }
    public void Explode()
    {
        Destroy(boom);
        boom = Instantiate(bomb);       
        explode = true;
        Destroy(boom, 5);
    }

    public void activateCannon()
    {
        cannon.active = !cannon.active;
    }
}
