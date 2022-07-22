using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoTornado : MonoBehaviour
{
    public Transform boxA, boxB, boxC, boxD;
    public float t;
    public bool Hek,Hek1,Hek2,Hek3 = false;

    void FixedUpdate()
    {
        if (Hek == false) 
        {
            transform.position = Vector3.Lerp(boxA.position, boxB.position, t);
            t = t + 0.001f;
            if (transform.position == boxB.position)
            {
                Hek = true;
                t = 0;
            }
        }
        else if (Hek1 == false)
        {
            transform.position = Vector3.Lerp(boxB.position, boxC.position, t);
            t = t + 0.001f;
            if (transform.position == boxC.position)
            {
                Hek1 = true;
                t = 0;
            }
        }
        else if (Hek2 == false)
        {
            transform.position = Vector3.Lerp(boxC.position, boxD.position, t);
            t = t + 0.001f;
            if (transform.position == boxD.position)
            {
                Hek2 = true;
                t = 0;
            }
        }
        else if (Hek3 == false)
        {
            transform.position = Vector3.Lerp(boxD.position, boxA.position, t);
            t = t + 0.001f;
            if (transform.position == boxA.position)
            { 
                t = 0;
                Hek = false;
                Hek1 = false;
                Hek2 = false;
                Hek3 = false;
            }
        }
    }
}
