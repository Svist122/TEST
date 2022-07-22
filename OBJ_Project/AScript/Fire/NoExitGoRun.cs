using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoExitGoRun : MonoBehaviour
{
    public GameObject GoRun;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            GoRun.SetActive(true);
        }
    }
}
