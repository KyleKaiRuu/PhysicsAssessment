using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodsHand : MonoBehaviour
{
    public bool active = false;
    public Camera mainCamera;
    private GameObject selectedBrick;
    public bool horizontal = true;
    public bool vertical = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                    RaycastHit hit;
                    Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.gameObject.tag != "bottom")
                        {
                            selectedBrick = hit.collider.gameObject;
                            selectedBrick.GetComponent<Rigidbody>().useGravity = false;
                        }
                    }
            }
            if (selectedBrick != null)
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    if (horizontal)
                    {
                        selectedBrick.transform.position += new Vector3(Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y"));
                    }
                    else if (vertical)
                    {
                        selectedBrick.transform.position += new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
                    }
                }
                if (Input.GetKeyUp(KeyCode.Mouse0))
                {
                    selectedBrick.GetComponent<Rigidbody>().useGravity = true;
                    selectedBrick = null;
                }
            }
        }
    }
}
