using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public GameObject  final;
    public string LVL;
    public float Time = 3.1f;


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            {
                final.SetActive(true);
                StartCoroutine(FinOut());
            }
        }
    }
    IEnumerator FinOut()
    {
        yield return new WaitForSeconds(Time);
        SceneManager.LoadScene(LVL);
    }
}
