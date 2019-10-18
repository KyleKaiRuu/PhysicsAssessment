using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Camera mainCamera;
    public bool active = false;
    public LineRenderer projectile;
    // Start is called before the first frame update
    void Start()
    {
        projectile.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (active)
            {
                RaycastHit hit;
                Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag != "bottom")
                    {
                        Destroy(hit.collider.gameObject);
                    }
                    projectile.SetPosition(0, (mainCamera.ScreenToWorldPoint(Input.mousePosition)- new Vector3(0,1,0)));
                    projectile.SetPosition(1, hit.point);
                    projectile.enabled = true;
                }
            }
        }
        else
        {
            projectile.enabled = false;
        }
    }
}
