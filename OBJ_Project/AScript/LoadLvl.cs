using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLvl : MonoBehaviour
{
    public string LVL;

    public void OnMouseDown()
    {
        SceneManager.LoadScene(LVL);
    }
}
