using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDestry : MonoBehaviour
{
    public GameObject audiom;
    public Portal pp;


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            {
                audiom.SetActive(true);
                Destroy(this.gameObject);
                pp.protalInt++;
            }
        }
    }
}
