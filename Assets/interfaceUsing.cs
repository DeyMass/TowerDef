using UnityEngine;
using System.Collections;

public class interfaceUsing : MonoBehaviour {
    public GameObject obj;
    GameObject ShowRange;
    GameObject Sphere;

    void OnMouseDown()
    {
		Instantiate(obj);
		obj.GetComponent<DrawRange>().enabled = false;
		obj.GetComponent<DrawRange> ().alpha = 1;
		//ShowRange.GetComponent<DrawRange> ().enabled = true;
		obj.GetComponent<DrawRange>().sphere = ShowRange;
		if (obj.transform.FindChild ("Sphere") == null)
			Sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		else {
			Sphere = obj.transform.FindChild ("Sphere").gameObject;
			Sphere.GetComponent<AttachTosSphere> ().isDragged = true;
			Sphere.GetComponent<MeshRenderer> ().material.color = new Color (0, 0, 0, 1);
			Sphere.GetComponent<DrawRange> ().enabled = false;
		}
        Sphere.transform.SetParent(obj.transform);
        Sphere.transform.localScale = new Vector3(20, 20);

    }
    void OnMouseUp() {
		obj.GetComponent<DrawRange>().enabled = true;
		Sphere.GetComponent<AttachTosSphere> ().isDragged = false;
        //Destroy(Sphere);
    }
	// Update is called once per frame
	void Update () {
        if (Sphere != null && obj != null)
        {
            Sphere.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, 10);
            Sphere.transform.localScale = new Vector3(20, 20);
        }
    }
}
