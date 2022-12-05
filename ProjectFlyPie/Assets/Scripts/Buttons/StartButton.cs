using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GMData data;
    public void OnClick()
    {
        data = GameObject.FindObjectOfType<GMData>();
        data.hasStarted = true;
    }
}
