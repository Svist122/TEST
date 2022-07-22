using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTriger : MonoBehaviour
{
    public GameObject TrigerAudio, TimeAudio1;
    public float time;
    public bool timeHekOn,timeHekOf = false;
    public bool trigerHekOf = false;
    public string Tags;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == Tags)
        {
            {
                if (trigerHekOf == true)
                {
                    TrigerAudio.SetActive(false);
                }
                else
                {
                    TrigerAudio.SetActive(true);
                }
            }
        }
    }
    private void Update()
    {
        StartCoroutine(TimeSek());
    }

    IEnumerator TimeSek()
    {
        if (timeHekOn == true) {         
            yield return new WaitForSeconds(time);
            TimeAudio1.SetActive(true);
        }
        if (timeHekOf == true)
        {
            yield return new WaitForSeconds(time);
            TimeAudio1.SetActive(false);
        }
    }
}
