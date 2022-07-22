using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nail : MonoBehaviour
{
    public Material materialNail;
    public WoodManager manager;
    private bool hek,NailOn,NailOf = false;
    private ParticleSystem bax;
    private AudioSource stuk;
    private void Start()
    {
        bax = GetComponent<ParticleSystem>();
        stuk = GetComponent<AudioSource>();
        bax.Pause();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Nail")
        {
           if (hek == false){ 
            wood WoodStop = col.gameObject.GetComponent<wood>();
                {
                    gameObject.GetComponent<MeshRenderer>().material = materialNail;
                    WoodStop.Stop();                   
                    hek = true;
                    NailOn = true;
                }
            }
        }
        else if (col.name == "Hamer")
        {
            if (NailOn == true)
            {
                if (NailOf == false)
                {
                    transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + 0.0746f);  //-29.3199 //-29.3945
                    bax.Play();
                    stuk.Play();
                    NailOf = true;
                    manager.woodint++;
                }
            }
        }
    }
}
