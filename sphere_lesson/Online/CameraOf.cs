using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraOf : MonoBehaviour
{
    private PhotonView photonView;
    public GameObject go, ManegerPrefab;

    void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (!photonView.IsMine) return;
        var myscript1 = gameObject.GetComponent<OVRHeadsetEmulator>();
        myscript1.enabled = true;
        var myscript2 = gameObject.GetComponent<OVRCameraRig>();
        myscript2.enabled = true;
        gameObject.AddComponent<OVRManager>();
        GameObject platform = Instantiate(ManegerPrefab, new Vector3(Random.Range(0, 0), 0), Quaternion.identity);
        platform.transform.SetParent(gameObject.transform, false);

    }


    void Update()
    {
        
    }
}
