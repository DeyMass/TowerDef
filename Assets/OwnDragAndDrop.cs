using UnityEngine;
using System.Collections;
using System;
public class OwnDragAndDrop : MonoBehaviour {
    int i = 0;
    //detect mouse Up or Down
    void OnMouseDown()
    {
        i = 1 - i;
    }

    void OnMouseUp()
    {
        i = 1 - i;
    }
    //********************************
    

    public GameObject toDrag;

    void Update ()
    {
        GameObject camera = GameObject.FindWithTag("MainCamera");
        Camera cam = camera.GetComponent<Camera>();
        if (i == 1)
        {
            Vector3 transf = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            toDrag.transform.position = cam.ScreenToWorldPoint(transf);
        }
    }
}
