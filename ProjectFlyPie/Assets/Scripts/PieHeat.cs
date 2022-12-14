using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieHeat : MonoBehaviour
{
    public HeatManager pieTile;
    public HeatManager heatValue;

    //sets the HeatValue of the tile the Pie spawns on top of to 100
    void OnTriggerEnter(Collider other)
    {
        pieTile = other.GetComponent<HeatManager>();
        pieTile.HeatValue = 100;
    }
}
//this needed to be done because by default every tile around the pie would likely
//have a higher HeatValue than the goal/pie, leading to the fly wandering around the pie
//while making the odds of choosing the pie tile lower with every move