using UnityEngine;
using System.Collections;

public class interfaceUsing : MonoBehaviour {
    public GameObject obj;
    void OnMouseDown() {
        Instantiate <GameObject>(obj);
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
