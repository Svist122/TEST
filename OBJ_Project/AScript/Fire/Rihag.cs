using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rihag : MonoBehaviour
{
    public HingeJoint SkeletRihag;

    public OVRInput.RawButton Handl = OVRInput.RawButton.RIndexTrigger;

    public OVRInput.RawButton HandR = OVRInput.RawButton.RIndexTrigger;

    public bool hek,hektime,hekdown = false;

    public GameObject Sirena, boxcolider, Arrow;

    public float UpdateHand,SecondHand;

    public void FixedUpdate()
    {
        var DownHandR = OVRInput.GetDown(HandR);
        var DownHandL = OVRInput.GetDown(Handl);
        var Down = Input.GetKeyDown(KeyCode.Tab);
        var UpHandR = OVRInput.GetUp(HandR);
        var UpHandL = OVRInput.GetUp(Handl);
        var Up = Input.GetKeyUp(KeyCode.Tab);

        if (Down || DownHandR || DownHandL)
        {
            if (hek == true)
            {
                hekdown = true;
            }
        }  
        
        if (Up || UpHandR || UpHandL)
        {
            hekdown = false;
        }

        if (hekdown == true)
     {
      JointSpring JJ = SkeletRihag.spring;

            if (UpdateHand < SecondHand)
            {
                if (JJ.targetPosition != 80f)
                {
                    JJ.targetPosition = JJ.targetPosition + 5f;
                    SkeletRihag.spring = JJ;
                }
                else if (JJ.targetPosition == 80f)
                {
                    Rihag other = gameObject.GetComponent<Rihag>();
                    Sirena.SetActive(true);
                    boxcolider.SetActive(false);
                    Arrow.SetActive(false);
                    other.enabled = false;
                }
            }  
                else if (UpdateHand > SecondHand)
                {
                    if (JJ.targetPosition != 0f)
                    {
                        JJ.targetPosition = JJ.targetPosition - 5f;
                        SkeletRihag.spring = JJ;
                    }
             }
     }                
}       
    
    void OnTriggerEnter(Collider col)
    {              
        if (col.name == "gripTrans")
        {
            hek = true;
        }
    }
    void OnTriggerExit(Collider col)
    {       
            hek = false;       
    }
    private void OnTriggerStay(Collider col)
    {
        if (col.name == "gripTrans")
        {
            UpdateHand = col.transform.position.y;
            StartCoroutine(TimeSek());          
        }
    }
    IEnumerator TimeSek()
    {
        if (hektime == false)
        {
            hektime = true;
            yield return new WaitForSeconds(0.001f);
            SecondHand = UpdateHand;
            hektime = false;
        }
    }
}
