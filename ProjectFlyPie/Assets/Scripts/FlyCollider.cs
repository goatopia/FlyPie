using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCollider : MonoBehaviour
{
    public GameObject currentFly;
    public GameObject tileName;
    public FlyNPieSpawner spawnerscript;

    //stores the name of the tile the fly is currently on: used by ColdButton script to reduce heat values of tiles
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("heatObject"))
        {
            tileName = other.gameObject;
        }
    }
}
