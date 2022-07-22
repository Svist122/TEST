using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stenkidown : MonoBehaviour
{
    public GameObject Stenki1, Stenki2,bax,firegaid;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
                Stenki1.SetActive(false);
                Stenki2.SetActive(true);
                bax.SetActive(true);
                StartCoroutine(FireOn());
        }
    }
    IEnumerator FireOn()
    {
        yield return new WaitForSeconds(2.5f);
        firegaid.SetActive(true);
    }
}
