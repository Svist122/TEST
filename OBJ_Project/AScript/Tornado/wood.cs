using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood : MonoBehaviour
{
    private Rigidbody rigid;

    public void Stop()
    {       
            Destroy(this.gameObject);
    }
}
