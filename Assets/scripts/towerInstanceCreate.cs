using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerInstanceCreate : MonoBehaviour
{

    private bool flag = false;
    public GameObject srcTower;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flag = true;
        }
        if (flag)
        {
            GameObject newTower = Instantiate<GameObject>(srcTower);
        }
    }
}