using UnityEngine;
using System.Collections;

public class TempWalking : MonoBehaviour
{
    void Update()
    {
        Transform transf = GetComponent<Transform>();
        transf.position += new Vector3(0.1f, 0, 0);
        if (Mathf.Round(transf.position.x) == 50)
            transf.position -= new Vector3(20,0,0);
    }
}

