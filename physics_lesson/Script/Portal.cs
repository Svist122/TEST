using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject svet, portal,moon;
    public GameObject svet2, portal2, mars,audio1;
    public int protalInt = 0;

 
    void Update()
    {
        if (protalInt == 3)
        {
            StartCoroutine(PortalON());        
        }
    }
    IEnumerator PortalON()
    {
        yield return new WaitForSeconds(25);
        svet.SetActive(true);
        portal.SetActive(true);
        audio1.SetActive(true);
        StartCoroutine(Mars());
    }
    IEnumerator Mars()
    {
        yield return new WaitForSeconds(13);
        svet2.SetActive(true);
        portal2.SetActive(true);
    }
}
