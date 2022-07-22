using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{
    
    public OVRInput.RawButton Handl = OVRInput.RawButton.RIndexTrigger;
    public OVRInput.RawButton HandR = OVRInput.RawButton.RIndexTrigger;

    public bool HekHand, HekFire,OnFire = false;
    public GameObject Par;

    private void Update()
    {
        var DownHandR = OVRInput.GetDown(HandR);
        var DownHandL = OVRInput.GetDown(Handl);
        var Down = Input.GetKeyDown(KeyCode.Tab);

        if (Down || DownHandR || DownHandL)
        {
            if (HekHand == true && OnFire == false)
            {
                Par.SetActive(true);
                OnFire = true;
            }
            else if (OnFire == true)
            {
                Par.SetActive(false);
                OnFire = false;
            }

        }
             if (HekHand == false)
            {
                Par.SetActive(false);
                OnFire = false;
            }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "HekHandGrab")
        {
            HekHand = true;
        }
        if (col.tag == "Fire")
        {
            if (OnFire == true)
            {
                col.gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "HekHandGrab")
        {
                HekHand = false;
        }
    }
}
