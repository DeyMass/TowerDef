﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DrawRange : MonoBehaviour {
    //public Material mat;
    public GameObject sphere = null;
    Transform self;
    float i = 0.0f;
    bool MouseOn;

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
        self = GetComponent<Transform>();
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        VisibleSphere = sphere.GetComponent<MeshRenderer>();
        Shader shader = Shader.Find("Transparent/Diffuse");
        VisibleSphere.material.shader = shader;
        
        sphere.transform.SetParent(self);
        sphere.transform.position = new Vector3(self.transform.position.x, self.transform.position.y, self.transform.position.z + 1);
        sphere.transform.localScale = new Vector3(20, 20, 0);
        Destroy(sphere.GetComponent<Collider>());
        Destroy(sphere.GetComponent<SphereCollider>());
        Destroy(sphere.GetComponent<CircleCollider2D>());


		sphere.AddComponent<AttachTosSphere> ();


        Debug.Log(sphere.GetComponent<SphereCollider>());
		   
        
    }
    bool firstframe = true;
    void Update ()
    {
        if (firstframe)
		{
			sphere.AddComponent<CircleCollider2D> ();
			sphere.AddComponent<Rigidbody2D> ().gravityScale = 0;
			sphere.GetComponent<Rigidbody2D> ().isKinematic = true;
			firstframe = false;
        }
        if (MouseOn)
            if (i < 1)
                i = i + 0.07f;

        if (!MouseOn)
        {
            if (i > 0)
                i = i - 0.07f;
        }
        if (VisibleSphere != null)
            VisibleSphere.material.color = new Color(0, 0, 0, i);
    }
}
