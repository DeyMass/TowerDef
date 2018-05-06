using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerRadiusHandler : MonoBehaviour {
    private MeshRenderer render;
    // Use this for initialization
    void Start () {
        render = transform.Find("RealRadius").gameObject.GetComponent<MeshRenderer>();
        render.enabled = false;
	}

	void OnMouseOver()
    {
        if(render != null)
            render.enabled = true;
    }

    void OnMouseExit()
    {
        render.enabled = false;
    }

	// Update is called once per frame
	void Update () {

	}
}
