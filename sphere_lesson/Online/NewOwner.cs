using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class NewOwner : MonoBehaviour
{
    private PhotonView photonView;
    public OVRInput.RawButton joyPadClickButton0 = OVRInput.RawButton.RIndexTrigger;
    public OVRInput.RawButton joyPadClickButton1 = OVRInput.RawButton.RIndexTrigger;

    public GameObject RukaL, RukaR;

    private void Start()
    {
        photonView = GetComponent<PhotonView>();
    }

    void OnTriggerEnter(Collider col)
    {
        var down0 = OVRInput.GetDown(joyPadClickButton0);
        var down1 = OVRInput.GetDown(joyPadClickButton1);


        if (col.tag == "Ruki")
        {
            if (down0 || down1)
            {
                this.photonView.RequestOwnership();
                Debug.Log("Комунизм");
            }
        }
    }
}
