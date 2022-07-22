using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class OfGolova : MonoBehaviour
{
    private PhotonView photonView;
    public GameObject golova,ruka1,ruka2;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (!photonView.IsMine) return;

        golova.SetActive(false);
        ruka1.SetActive(true);
        ruka2.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
