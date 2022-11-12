using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatManager : MonoBehaviour
{
    [Tooltip("The fly can use this int to navigate")] [SerializeField] private int HeatValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fly"))
        {
            HeatValue += 1;
            Debug.Log("HeatValue is now: " + HeatValue);
        }
    }
}
