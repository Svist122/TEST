using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class But : MonoBehaviour
{
    public GameObject Lazer;
    public bool ShekInput = false;
    void Update()
    {
        bool down = Input.GetButtonDown("Oculus_CrossPlatform_Button4");
        if (down)
        {
            if (ShekInput == false)
            {
                Lazer.SetActive(false);
                ShekInput = true;
            }
            else if (ShekInput == true)
            {
                Lazer.SetActive(true);
                ShekInput = false;
            }
        }
    }
}
