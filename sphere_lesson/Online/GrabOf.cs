using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GrabOf : MonoBehaviour
{
    private PhotonView photonView;
    public GameObject tt;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (photonView.IsMine) return;

        tt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
