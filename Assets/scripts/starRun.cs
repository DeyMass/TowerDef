using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starRun : MonoBehaviour {

    //public Camera cam;
    public GameObject endPoint;
    public UnityEngine.AI.NavMeshAgent agent;


	// Use this for initialization
	void Start () {
        agent.SetDestination(new Vector3(endPoint.transform.position.x, endPoint.transform.position.y, endPoint.transform.position.z));
    }
}
