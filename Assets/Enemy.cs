using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    MeshRenderer HealthBarColor;
    public float Health = 100;
    void Start()
    {
        //gameObject.AddComponent<Rigidbody2D>().gravityScale = 0;
		gameObject.GetComponent<Collider2D> ().isTrigger = true;

        GameObject HealthBar = GameObject.CreatePrimitive(PrimitiveType.Quad);
        HealthBar.transform.SetParent(gameObject.transform);
        HealthBar.transform.position = 
                                gameObject.transform.position + new Vector3(0, 2f);
        HealthBar.transform.localScale += new Vector3(3.4f, -1f);

        HealthBarColor = HealthBar.GetComponent<MeshRenderer>();
        
    }
		 

	void Update()
    {
        if (Mathf.Round(Health) <= 0)
            Destroy(gameObject);
        if (HealthBarColor != null)
			HealthBarColor.material.color = new Color((6 - (6 * Health) / 100), (6 * Health) / 100, 0);
    }
}