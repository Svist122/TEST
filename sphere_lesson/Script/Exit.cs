using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button Button1;
    void Start()
    {
        Button btn1 = Button1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);
    }

    // Update is called once per frame
    void TaskOnClick1()
    {
        Application.LoadLevel("Menu");
    }
}
