using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    Material thiscolor;
    public Material smena,smena1;

    public Material Cure;

    [Range(0f, 1f)]

    public float t;

    private void Start()
    {
    }

    private void FixedUpdate()
    {
        Cure.color = Color.Lerp(smena1.color,smena.color, t);        
    }
}

