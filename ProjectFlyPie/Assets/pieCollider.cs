using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieCollider : MonoBehaviour
{
    public FlyDecider flyChoice;
    public HeatManager pieTile;
    public HeatManager heatValue;
    public HeatManager pieHeat;
        public void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("heatObject"))
            {
                // have the tile under this pie add its heat value to a big number like 100 or so

                //pieTile = other.gameObject;
                pieHeat = other.GetComponent<HeatManager>();
                pieHeat.HeatValue = 100;
            }
        }
    
}
