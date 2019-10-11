using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileSelection : MonoBehaviour
{
    public Dropdown selection;
    public Slider velocity;
    public CannonBall launcher;
    public List<GameObject> projectiles;
    private List<string> names = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        selection.ClearOptions();
        for (int i = 0; i < projectiles.Count; i++)
        {
            names.Add(projectiles[i].name);
        }
        selection.AddOptions(names);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeProjectile()
    {
        launcher.cannonBall = projectiles[selection.value];
    }
    public void ChangeVelocity()
    {
        launcher.timeTillImpact = (int)velocity.value;
    }
    
}
