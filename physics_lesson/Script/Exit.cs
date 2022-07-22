using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    void OnTriggerEnter(Collider cool)
    {
        if (cool.CompareTag("Player"))
        {          
            Application.Quit();
        }

    }
}
