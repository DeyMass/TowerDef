using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInterfaceHandler : MonoBehaviour {

    public GameObject srcTower;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.N)){
            GameObject copy = Instantiate<GameObject>(srcTower);
            copy.GetComponent<PlaceTowerScript>().enabled = true;
            copy.GetComponent<MyDragAndDrop>().enabled = true;
        }
	}
}
