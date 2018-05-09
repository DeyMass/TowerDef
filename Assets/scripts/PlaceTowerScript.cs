using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTowerScript : MonoBehaviour {
    public Camera cam;
    private float castDistance = 50f;
	void Start () {
        this.GetComponent<towerRadiusHandler>().enabled = false;
        transform.Find("RealRadius").gameObject.SetActive(false);
        transform.Find("tower/Sphere/Effect").gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Vector3 center = transform.position;
            Vector3 rT, lT, rB, lB;
            rT = center + new Vector3(2.5f, 0, 2.5f);
            lT = center + new Vector3(-2.5f, 0, 2.5f);
            rB = center + new Vector3(2.5f, 0, -2.5f);
            lB = center + new Vector3(-2.5f, 0, -2.5f);
            
            RaycastHit hit1, hit2, hit3, hit4;
            Ray ray1, ray2, ray3, ray4;
            
            ray1 = new Ray(rT, Vector3.down);
            ray2 = new Ray(lT, Vector3.down);
            ray3 = new Ray(rB, Vector3.down);
            ray4 = new Ray(lB, Vector3.down);

            Physics.Raycast(ray1, out hit1, castDistance);
            Physics.Raycast(ray2, out hit2, castDistance);
            Physics.Raycast(ray3, out hit3, castDistance);
            Physics.Raycast(ray4, out hit4, castDistance);

            RaycastHit rayCheck;
            Physics.BoxCast(transform.position, new Vector3(1, 1, 1), Vector3.up, out rayCheck);
            if (rayCheck.transform)
            {
                if (rayCheck.transform.gameObject.tag == "Tower")
                    print("OPPPA");
            }
            if (hit1.transform != null && hit2.transform != null && hit3.transform != null && hit4.transform != null)
            {
                GetComponent<MyDragAndDrop>().enabled = false;
                GetComponent<PlaceTowerScript>().enabled = false;
                GetComponent<towerRadiusHandler>().enabled = true;

                
                transform.Find("tower/Sphere/Effect").gameObject.SetActive(true);

                transform.Find("RealRadius").gameObject.SetActive(true);
                transform.Find("RealRadius").gameObject.GetComponent<MeshRenderer>().enabled = true;
                transform.Find("FakeRadius").gameObject.SetActive(false);
            }
        }
	}
}
