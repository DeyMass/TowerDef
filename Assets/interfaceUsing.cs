using UnityEngine;
using System.Collections;

public class interfaceUsing : MonoBehaviour {
    public GameObject obj;
    GameObject ShowRange;
    GameObject Sphere;

    void OnMouseDown()
    {
		ShowRange = Instantiate(obj);
		ShowRange.GetComponent<DrawRange>().enabled = false;
		//ShowRange.GetComponent<DrawRange> ().enabled = true;
		ShowRange.GetComponent<DrawRange>().sphere = ShowRange;
        Sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        
        Sphere.transform.SetParent(ShowRange.transform);
        Sphere.transform.localScale = new Vector3(10, 10);

    }
    void OnMouseUp() {
        ShowRange.GetComponent<DrawRange>().enabled = true;
        //Destroy(Sphere);
    }
	// Update is called once per frame
	void Update () {
        if (Sphere != null && ShowRange != null)
        {
            Sphere.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, 10);
            Sphere.transform.localScale = new Vector3(20, 20);
        }
    }
}
