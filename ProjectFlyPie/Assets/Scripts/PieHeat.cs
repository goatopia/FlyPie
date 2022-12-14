using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieHeat : MonoBehaviour
{
    public HeatManager pieTile;
    public HeatManager heatValue;


    void OnTriggerEnter(Collider other)
    {
        pieTile = other.GetComponent<HeatManager>();
        pieTile.HeatValue = 100;
    }
}
