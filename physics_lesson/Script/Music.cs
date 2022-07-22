using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public MusicOFF Mus;
    public GameObject Audio;


    public void OnMouseDown()
    {
        Mus.OffMus();

        Audio.SetActive(true);
    }
}
