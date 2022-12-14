using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GMData data;
    public void OnClick()
    {
        //Send information to the game manager (the game has started)
        data = GameObject.FindObjectOfType<GMData>();
        data.hasStarted = true;
    }
}
