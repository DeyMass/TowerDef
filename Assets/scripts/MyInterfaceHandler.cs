using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInterfaceHandler : MonoBehaviour {
    private bool isInProcess;
    public GameObject srcTower;

	// Use this for initialization
	void Start () {
        isInProcess = false;
	}
	
    public void placeSuccess()
    {
        isInProcess = false;
    }
    public void createTower()
    {
        if (isInProcess) return;
        isInProcess = true;
        GameObject copy = Instantiate<GameObject>(srcTower);
        copy.GetComponent<PlaceTowerScript>().enabled = true;
        copy.GetComponent<MyDragAndDrop>().enabled = true;
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.N)){
            
        }
	}
}
