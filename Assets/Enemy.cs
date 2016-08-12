using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
    public static void MoveTo(ref GameObject which, ref GameObject where) {
        /*float x, y, toX, toY;
        //int reached = 0;
       
        x = which.transform.position.x;
        y = which.transform.position.y;
        toX = where.transform.position.x;
        toY = where.transform.position.y;
        /*while (reached != 2)
        {
            if (x == toX)
            {
                reached++;
                break;
            }
            if (y == toY)
            {
                reached++;
                break;
            }*/
        print(which);
        print(where);
        
        //   reached = 2;

        // }
    }
}
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