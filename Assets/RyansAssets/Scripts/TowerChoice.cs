using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerChoice : MonoBehaviour
{
    public GameObject defaultTower;
    public GameObject spawnPoint;
    public Dropdown towerSelection;
    public Button reset;

    public List<GameObject> avaliableTowers;
    private List<string> towerNames = new List<string>();

    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(avaliableTowers[0], gameObject.transform);

        //sets up the dropdown to contain all option
        towerSelection.ClearOptions();
        for (int i = 0; i < avaliableTowers.Count; i++)
        {
            towerNames.Add(avaliableTowers[i].name);
        }
        towerSelection.AddOptions(towerNames);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeTower()
    {
        Destroy(transform.GetChild(0).gameObject);
        //defaultTower = avaliableTowers[towerSelection.value];
        Instantiate(avaliableTowers[towerSelection.value], gameObject.transform);
    }
    
}
