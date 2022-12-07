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
        HeatValue = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fly"))
        {
            HeatValue += 1;
        }
    }

    private void Update()
    {
        heatdisplay.text = HeatValue.ToString();

    }
}
