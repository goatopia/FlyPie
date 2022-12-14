using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeatManager : MonoBehaviour
{
    public int HeatValue; //{get; private set;}
    public TMP_Text heatdisplay;
    private void Awake()
    {
        HeatValue = 1;//sets all tiles' HeatValue to 1 so that the choiceWeight list of available directions isn't empty
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fly"))
        {
            HeatValue += 1;//adds 1 to the HeatValue of a tile every time the fly lands on it
        }
    }

    private void Update()
    {
        heatdisplay.text = HeatValue.ToString();//Displays the heat value so that players can see

    }
}
