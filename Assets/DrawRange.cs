using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DrawRange : MonoBehaviour {
    //public Material mat;
    public GameObject sphere = null;
    Transform self;
    public float alpha = 0.0f;
    bool MouseOn = false;

    void OnMouseOver()
    {
        MouseOn = true;
    }

    void OnMouseExit()
    {
        MouseOn = false;
    }
    

    MeshRenderer VisibleSphere;
    void Start()
    {
        self = gameObject.GetComponent<Transform>();
		sphere = gameObject.transform.GetChild(0).gameObject;

        VisibleSphere = sphere.GetComponent<MeshRenderer>();
		Shader shader = Shader.Find("Transparent/Diffuse");
        VisibleSphere.material.shader = shader;
		sphere.transform.SetParent (self);
        sphere.transform.position = new Vector3(self.transform.position.x, 
												self.transform.position.y, 
												self.transform.position.z + 1);
        sphere.transform.localScale = new Vector3(20, 20, 0);
		Destroy (sphere.GetComponent<SphereCollider> ());
		//Destroy (self.GetChild (1).gameObject);
		gameObject.GetComponent<BoxCollider2D>().isTrigger = true;

		sphere.AddComponent<AttachTosSphere> ();
//		sphere.AddComponent<Rigidbody2D> ();
    }
	int nframe = 0;
    void Update ()
    {
		nframe++;
		if (nframe == 2) {
			if (sphere.GetComponent<CircleCollider2D>() == null)
			sphere.AddComponent<CircleCollider2D> ();
			if (sphere.GetComponent<Rigidbody2D>() == null)
				sphere.AddComponent<Rigidbody2D> ();
			sphere.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;

			sphere.GetComponent<Rigidbody2D> ().isKinematic = true;
		}

		if (MouseOn) {
			if (alpha < 1)
				alpha = alpha + 0.07f;
		}
        if (!MouseOn)
        {
            if (alpha > 0)
                alpha = alpha - 0.07f;
        }
		if (VisibleSphere != null)
            VisibleSphere.material.color = new Color(0, 0, 0, alpha);
    }
}
