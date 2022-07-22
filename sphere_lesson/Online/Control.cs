using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[RequireComponent(typeof(PhotonView))]
public class Control : MonoBehaviour
{
    private PhotonView photonView;
    public GameObject Camera1, Camera2, Camera3;
    public GameObject player;
    public CameraOf Test;

    void Start()
    {
        photonView = GetComponent<PhotonView>();
        if (photonView.IsMine) return;
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);

        var _myscript = gameObject.GetComponent<OVRPlayerController>();
        _myscript.enabled = false;
        var myscript = gameObject.GetComponent<OVRSceneSampleController>();
        myscript.enabled = false;
    }

}
