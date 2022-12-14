using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCollider : MonoBehaviour
{
    public GameObject currentFly;
    public GameObject tileName;
    public FlyNPieSpawner spawnerscript;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("heatObject"))
        {
            tileName = other.gameObject;
        }
    }
}
