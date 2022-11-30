using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatManager : MonoBehaviour
{
    [Tooltip("The fly can use this int to navigate")] [SerializeField] private int HeatValue;
    //making a public variable that will increase the same as HeatValue but will be visible from a RayCast from the Fly
    public int HeatDetect = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fly"))
        {
            HeatValue += 1;
            Debug.Log("HeatValue is now: " + HeatValue);
            HeatDetect += 1;
            Debug.Log("HeatDetect for " + this + " is " + HeatDetect);
        }
    }
}
