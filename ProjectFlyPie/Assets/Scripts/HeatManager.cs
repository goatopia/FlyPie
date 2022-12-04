using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatManager : MonoBehaviour
{
    public int HeatValue; //{get; private set;}

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
}
