using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButOrgan : MonoBehaviour
{
    public Button Button1, Button2, Button3, Button4, Button5;
    public GameObject play1,stop1, play2, stop2, play3, stop3, play4, stop4, play5, stop5;
    public GameObject Music1, Music2, Music3, Music4, Music5;
    private bool ven1,ven2,ven3,ven4,ven5 = true;



    void Start()
    {
        Button btn1 = Button1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);
        Button btn2 = Button2.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
        Button btn3 = Button3.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick3);
        Button btn4 = Button4.GetComponent<Button>();
        btn4.onClick.AddListener(TaskOnClick4);
        Button btn5 = Button5.GetComponent<Button>();
        btn5.onClick.AddListener(TaskOnClick5);
    }

    // Update is called once per frame
    void TaskOnClick1(){
        if (ven1 == true){
            MusOFF();
            play1.SetActive(false);
            stop1.SetActive(true);
            Music1.SetActive(true);
            ven1 = false;
        }
        else if (ven1 == false){
            MusOFF();
            ven1 = true;
        }
    }
    void TaskOnClick2(){
        if (ven2 == true){
            MusOFF();
            play2.SetActive(false);
            stop2.SetActive(true);
            Music2.SetActive(true);
            ven2 = false;
        }
        else if (ven2 == false){
            MusOFF();
            ven2 = true;
        }
    }
    void TaskOnClick3(){
        if (ven3 == true){
            MusOFF();
            play3.SetActive(false);
            stop3.SetActive(true);
            Music3.SetActive(true);
            ven3 = false;
        }
        else if (ven3 == false){
            MusOFF();
            ven3 = true;
        }
    }
    void TaskOnClick4(){
        if (ven4 == true){
            MusOFF();
            play4.SetActive(false);
            stop4.SetActive(true);
            Music4.SetActive(true);
            ven4 = false;
        }
        else if (ven4 == false){
            MusOFF();
            ven4 = true;
        }
    }
    void TaskOnClick5(){
        if (ven5 == true){
            MusOFF();
            play5.SetActive(false);
            stop5.SetActive(true);
            Music5.SetActive(true);
            ven5 = false;
        }
        else if (ven5 == false){
            MusOFF();
            ven5 = true;
        }
    }
    void MusOFF()
    {
        Music1.SetActive(false);
        Music2.SetActive(false);
        Music3.SetActive(false);
        Music4.SetActive(false);
        Music5.SetActive(false);
        play1.SetActive(true);
        stop1.SetActive(false);
        play2.SetActive(true);
        stop2.SetActive(false);
        play3.SetActive(true);
        stop3.SetActive(false);
        play4.SetActive(true);
        stop4.SetActive(false);
        play5.SetActive(true);
        stop5.SetActive(false);
    }
}
