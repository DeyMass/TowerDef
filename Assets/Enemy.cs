using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
    public static void MoveTo(ref GameObject which, ref GameObject where) {
        float x, y, toX, toY;
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

    void Start()
    {
        //EMPTY
    }

    void Update()
    {
        //EMPTY
    }
}