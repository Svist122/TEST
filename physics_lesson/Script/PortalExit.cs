using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalExit : MonoBehaviour
{
    public Transform players;
    public Transform moon;
    public GameObject ofObject, onObject, audio1; 
    public Material MyMat;

    void OnTriggerEnter(Collider cool)
    {
        if (cool.CompareTag("Player"))
        {
            {
                players.gameObject.SetActive(false);
                players.position = moon.position;
                players.gameObject.SetActive(true);
                ofObject.SetActive(false);
                onObject.SetActive(true);
                audio1.SetActive(true);
                RenderSettings.skybox = MyMat;
            }
        }
        
    }
}
