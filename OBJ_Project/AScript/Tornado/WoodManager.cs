using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodManager : MonoBehaviour
{
    public int woodint;
    public GameObject Nail, audioHamer, audiovehi, box;


    void Update()
    {
        if (woodint == 4)
        {
            audioHamer.SetActive(true);
            Nail.SetActive(true);
        }
        if (woodint == 20) 
        {
            audiovehi.SetActive(true);
            box.SetActive(true);
        }
    }
}
