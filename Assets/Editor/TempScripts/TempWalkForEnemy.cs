using UnityEngine;
using System.Collections;

public class TempWalkForEnemy : MonoBehaviour {
    void Start() {
    }
    
	void Update ()
    {
        Transform transf = GetComponent<Transform>();
        
        transf.position += new Vector3(1,0,0);
	}
}
