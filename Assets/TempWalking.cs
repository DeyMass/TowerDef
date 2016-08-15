using UnityEngine;
using System.Collections;

public class TempWalking : MonoBehaviour
{

	void Start()
	{
/*		GameObject[] Way = GameObject.FindGameObjectsWithTag ("Land");
		foreach(GameObject elem in Way)
			Debug.Log (elem);
		
		Debug.Log (Way [0]);	*/
	}

    void Update()
    {
        Transform transf = GetComponent<Transform>();

        transf.position += new Vector3(1, 0, 0);
        if (Mathf.Round(transf.position.x) == 60)
            transf.position -= new Vector3(30, 0);

    }
}

