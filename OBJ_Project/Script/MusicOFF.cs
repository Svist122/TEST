using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOFF : MonoBehaviour
{
    public AudioSource[] Sound;
    public GameObject Parent;
    public int a;
    private void Start()
    {
        Sound = Parent.GetComponentsInChildren<AudioSource>();
        a = Sound.Length;

        for (int i = 0; i < a; i++)
        {
            Sound[i].gameObject.SetActive(false);
        }

    }
    public void OffMus()
    {
        for (int i = 0; i < a; i++)
        {
            Sound[i].gameObject.SetActive(false);
        }
    }
}
