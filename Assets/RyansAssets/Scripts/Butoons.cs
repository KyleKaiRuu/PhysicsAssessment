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
    public CannonBall cannon;
    public Laser laser;
    public GodsHand hand;
    public WreckingBall ball;


    private void Update()
    {
        if (boom == null)
        {
            explode = false;
        }
        else if (explode)
        {
            boom.transform.localScale += new Vector3(5, 5, 5);
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
    public void ActivateLaser()
    {
        laser.active = !laser.active;
    }
    public void ActivateGodsHand()
    {
        hand.active = !hand.active;
    }
    public void ActiveWreckingBall()
    {
        ball.active = !ball.active;
    }
    public void close()
    {
        Application.Quit();
    }
   
}
