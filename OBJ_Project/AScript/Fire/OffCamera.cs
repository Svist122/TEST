using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffCamera : MonoBehaviour
{
    public Image bg;
    public GameObject Fire, NoFire;
    public GameObject Ser, Bax;
    private bool firelvl = true;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (firelvl == true)
            {
                Bax.SetActive(true);
                StartCoroutine(c_Alpha(1.0f, 2.0f));
                
                StartCoroutine(CameraTrue());
                StartCoroutine(FireOn());
                firelvl = false;
            }
        }
    }

    void Start()
    {
           StartCoroutine(c_Alpha(0.0f, 2.0f));     
    }

    IEnumerator c_Alpha(float value, float time)
    {
        float k = 0.0f;
        Color c0 = bg.color;
        Color c1 = c0;
        c1.a = value;

        while ((k += Time.deltaTime) <= time)
        {
            bg.color = Color.Lerp(c0, c1, k / time);

            yield return null;
        }

        bg.color = c1;
    }
    IEnumerator CameraTrue()
    {           
        yield return new WaitForSeconds(3.5f);
        NoFire.SetActive(false);
        Fire.SetActive(true);
    }
    IEnumerator FireOn()
    {
        this.transform.position = new Vector3(100, 100, 100);
        yield return new WaitForSeconds(5);
        Debug.Log("privet mir");
        StartCoroutine(c_Alpha(0.0f, 2.0f));
        Ser.SetActive(true);        
    }
}
