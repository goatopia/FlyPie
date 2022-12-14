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
            /*
            if (other.CompareTag("heatObject"))
            {
                Debug.Log("pie :)");
                
                
                pieHeat = other.GetComponent<HeatManager>();
                pieHeat.HeatValue = 100;
                
            }
            */

            if (other.CompareTag("Fly")){
                Debug.Log(":) u win");
            }
        }    
}
