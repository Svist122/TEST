using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using OVRTouchSample;
using OculusSampleFramework;

public class Kulak : MonoBehaviour
{
    private PhotonView photonView;

    void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (photonView.IsMine) return;

        
        var _myscript1 = gameObject.GetComponent<Hand>();
        _myscript1.enabled = false;
        var _myscript2 = gameObject.GetComponent<DistanceGrabber>();
        _myscript2.enabled = false;
        var _myscript = gameObject.GetComponent<OVRGrabber>();
        _myscript.enabled = false;



    }

    
    void Update()
    {
        
    }
}
