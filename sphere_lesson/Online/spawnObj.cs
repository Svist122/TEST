using OculusSampleFramework;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObj : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(SpawnTrap());

    }

    IEnumerator SpawnTrap()
    {
        yield return new WaitForSeconds(2);
        
        var _myscript = gameObject.GetComponent<DistanceGrabbable>();
        _myscript.enabled = true;
      
    }

    // Update is called once per frame
}
