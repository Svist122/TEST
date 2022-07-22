using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class musras : MonoBehaviour
{
    public GameObject Parent;
    public Transform[] Skelet;
    float smoothTime = 0f;
    public int a = 154;
    public Button yourButton0;
    // Start is called before the first frame update
    void Start()
    {
        Skelet = Parent.GetComponentsInChildren<Transform>().Skip(1).ToArray();
        Button btn0 = yourButton0.GetComponent<Button>();
        btn0.onClick.AddListener(TaskOnClick0);
    }
    void TaskOnClick0()
    {
        for (int i = 0; i < a; i++)
        {
            Skelet[i].position = new Vector4(Random.Range(-0.634f, -2.834f), 1.328f, 7.652f, Time.deltaTime * smoothTime);
        }
    }
}
