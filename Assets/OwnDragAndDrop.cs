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
    public bool snap = true;
    private Vector3 transf;
    void Update ()
    {
        GameObject camera = GameObject.FindWithTag("MainCamera");
        Camera cam = camera.GetComponent<Camera>();
        if (i == 1)
        {
            transf = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            if (snap)
            {
                Vector3 temp = cam.ScreenToWorldPoint(transf);
                toDrag.transform.position = new Vector3(Mathf.Round(temp.x),
                                                        Mathf.Round(temp.y),
                                                        Mathf.Round(temp.z));
            }
            else
                toDrag.transform.position = cam.ScreenToWorldPoint(transf);

        }
        
    }
}
