using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieCollider : MonoBehaviour
{
    //what do these do? (flyChoice, pieTile, heatValue, pieHeat)?
    public FlyDecider flyChoice;
    public HeatManager pieTile;
    public HeatManager heatValue;
    public HeatManager pieHeat;

    //stuff that I know is being used below (michael)
    private FlyNPieSpawner generationManager;
    private int layerMask = 1 << 6; //hit the fly layer only
    
    private void flySense() //detect the fly
    {
        RaycastHit hit;
        Ray flyRay = new Ray(transform.position, transform.up);
        
        if(Physics.Raycast(flyRay, out hit, 3f, layerMask))
        {
            win();
        }
    }

    private void win()
    {
        Debug.Log("the fly found the pie!");
        generationManager = FindObjectOfType<FlyNPieSpawner>();
        Destroy(GameObject.FindWithTag("Fly")); //remove old fly
        generationManager.activeFlies.Remove(generationManager.currentFly);
        Debug.Log(generationManager.activeFlies.Count);

        
    }
  
  private void FixedUpdate()
  {
    flySense();
  }
}
