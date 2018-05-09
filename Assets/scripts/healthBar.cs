using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour {

    public void UpdateHealthBar(int Value, int MaxValue)
    {
        if (Value <= 0) Destroy(this);
        if (this.GetComponent<MeshRenderer>() == null) return;
        float percent = (float)Value / (float)MaxValue;
        int sumColor = (int)(percent * (255f + 255f));
        //print("R + G = " + sumColor);
        int r = 510 - sumColor;
        int g = sumColor;
        r = r > 255 ? 255 : r;
        g = g > 255 ? 255 : g;
        g = g < 0 ? 0 : g;
        this.GetComponent<MeshRenderer>().materials[0].SetColor("_EmissionColor", new Color32((byte)r, (byte)g, 0, 255));
    }
}
