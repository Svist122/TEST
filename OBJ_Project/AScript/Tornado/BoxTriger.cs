using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTriger : MonoBehaviour
{
    private int food, water, radio, flood = 0;
    public GameObject podvalaudio, boxA, boxB, listproviant , podvalof, podvalon;
    private bool hek = false;
    private BoxCollider calid; 
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Water")
        {
            water++;
        }
        else if (col.name == "Food")
        {
            food++;
        }
        else if (col.name == "Radio")
        {
            radio++;
        }
        else if (col.name == "Flood")
        {
            flood++;
        }
    }
    private void OnTriggerStay(Collider col)
    {
        if (hek == true)
        {
            if (col.name == "Water")
            {
                Destroy(col.gameObject);
            }
            else if (col.name == "Food")
            {
                Destroy(col.gameObject);
            }
            else if (col.name == "Radio")
            {
                Destroy(col.gameObject);
            }
            else if (col.name == "Flood")
            {
                Destroy(col.gameObject);
            }           
        }
    }
    void Start()
    {
        calid = GetComponent<BoxCollider>();
        listproviant.SetActive(true);
    }
    void Update()
    {
        if (food >= 3 && water >= 3 && radio >= 1 && flood >= 2)
        {
            hek = true;
            boxA.SetActive(false);
            boxB.SetActive(true);
            podvalaudio.SetActive(true);
            podvalon.SetActive(true);
            podvalof.SetActive(false);
            StartCoroutine(TimeSek());
        }
    }
    IEnumerator TimeSek()
    {
        yield return new WaitForSeconds(0.001f);
        calid.enabled = false;
    }
}
