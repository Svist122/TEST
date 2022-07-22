using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandWood : MonoBehaviour
{
    public Material materialWood;
    private StandWood Woodhek;
    public WoodManager manager;

    void Start()
    {
         Woodhek = GetComponent<StandWood>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Wood")
        {
            wood WoodStop = col.gameObject.GetComponent<wood>();
            {
                gameObject.GetComponent<MeshRenderer>().material = materialWood;
                WoodStop.Stop();
                manager.woodint++;
                Destroy(Woodhek);
            }
        }
    }
}
