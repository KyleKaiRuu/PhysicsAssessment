using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public Camera mainCamera;
    public float angle;
    public GameObject cannonBall;
    public int timeTillImpact = 4;

    private Vector3 target;
   

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                target = hit.point;
                GameObject projectile = Instantiate(cannonBall, transform.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>().velocity = CalculateLaunchVelocityForTime(transform.position,target, timeTillImpact);
                Destroy(projectile, 15);
            }
        }
    }


    Vector3 CalculateLaunchVelocityForTime(Vector3 start, Vector3 target, float time)
    {
        //this is terrys stoof
        Vector3 launchVelocity;
        launchVelocity.x = (target.x - start.x) / time;
        launchVelocity.z = (target.z - start.z) / time;

        launchVelocity.y = (target.y + 0.5f * -Physics.gravity.y * time * time - start.y) / time;

        return launchVelocity;
    }

    // did not reach target if y value was to high
    //public Vector3 BalisticVelocity(Vector3 target, float fireangle)
    //{
    //    Vector3 dir = target - transform.position;
    //    float h = dir.y;
    //    //dir.y = 0;
    //    float dist = dir.magnitude;
    //    float a = fireangle * Mathf.Deg2Rad;
    //    dir.y = dist * Mathf.Tan(a);
    //    dist += h / Mathf.Tan(a);
    //    float vel = Mathf.Sqrt(dist * Physics.gravity.magnitude / Mathf.Sin(2 * a));
    //    return vel * dir.normalized;
    //}
}
