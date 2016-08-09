using UnityEngine;
using System.Collections;

public class SnapToGrid : MonoBehaviour {

	void Update () {
        Transform track = GetComponent<Transform>();
        track.transform.position = new Vector3((int)Input.mousePosition.x / 50,(int) Input.mousePosition.y / 50, 10);
    }
}
