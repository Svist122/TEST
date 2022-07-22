using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public OVRPlayerController jumping;
    public OVRInput.RawButton joyPadClickButton0 = OVRInput.RawButton.RIndexTrigger;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var Jumpig = OVRInput.GetDown(joyPadClickButton0);
        var Jum = Input.GetKeyDown(KeyCode.Tab);

        if (Jumpig || Jum)
        {
            jumping.Jump();
            Debug.Log("asdasd");
        }
    }
}
