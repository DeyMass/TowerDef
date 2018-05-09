using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDragAndDrop : MonoBehaviour {

    public GameObject obj;
    public Camera cam;

    // Update is called once per frame
    void Update() {
        Ray ray1 = cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHit;
        
        if (Physics.Raycast(ray1, out rayHit, 100.0f))
        {
            obj.transform.position = new Vector3(rayHit.point.x, obj.transform.position.y, rayHit.point.z);
        }
    }
}
