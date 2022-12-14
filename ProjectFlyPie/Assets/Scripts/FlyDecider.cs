using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDecider : MonoBehaviour
{
    //where we ultimately decide to go
    public int Direction;

    //weighted list used to choose a direction
    public List<int> choiceWeight = new List<int>();

    //exclude the fly from being hit by our raycasts
    private int layerMask = 1 << 8;

        public void LookAround()
    {
        RayForward();
        RayRight();
        RayBackward();
        RayLeft();
    }

    //reference a heat value and use it to compile our list
    void RayForward()
    {
        //send out a ray
        RaycastHit hitData;
        Ray ray1 = new Ray(transform.position, transform.forward);

        //did we hit anything
        if(Physics.Raycast(ray1, out hitData, 1f, layerMask))
        {
            //add the integer '1' to the list n times, where n = HeatValue
            HeatManager heatManager = hitData.transform.GetComponent<HeatManager>();
            for(int i = 0; i < heatManager.HeatValue; i++)
            {
                choiceWeight.Add(1);
            }
        }
    }
    
    void RayRight()
    {
        //send out a ray
        RaycastHit hitData;
        Ray ray2 = new Ray(transform.position, transform.right);

        //did we hit anything
        if(Physics.Raycast(ray2, out hitData, 1f, layerMask))
        {
            //add the integer '2' to the list n times, where n = HeatValue
            HeatManager heatManager = hitData.transform.GetComponent<HeatManager>();

            for(int i = 0; i < heatManager.HeatValue; i++)
            {
                choiceWeight.Add(2);
            }     
        }
    }    
    
    void RayBackward()
    {
        //send out a ray
        RaycastHit hitData;
        Ray ray3 = new Ray(transform.position, -transform.forward);

        //did we hit anything
        if (Physics.Raycast(ray3, out hitData, 1f, layerMask))
        {
            //add the integer '3' to the list n times, where n = HeatValue
            HeatManager heatManager = hitData.transform.GetComponent<HeatManager>();

            for(int i = 0; i < heatManager.HeatValue; i++)
            {
                choiceWeight.Add(3);
            }     
        }
    }

    void RayLeft()
    {
        //send out a ray
        RaycastHit hitData;
        Ray ray4 = new Ray(transform.position, -transform.right);

        //did we hit anything
        if (Physics.Raycast(ray4, out hitData, 1f, layerMask))
        {
            //add the integer '4' to the list n times, where n = HeatValue
            HeatManager heatManager = hitData.transform.GetComponent<HeatManager>();

            for(int i = 0; i < heatManager.HeatValue; i++)
            {
                choiceWeight.Add(4);
            }     
        }
    }

    public void moveFly()
    {
        //Select a direction from the list at random
        int random = Random.Range(0, choiceWeight.Count);
        
        if(choiceWeight.Count == 0) //if all the available tiles have a heat of 0, randomly pick
        {
        Direction = Random.Range(1,5); //known bug: this will allow the fly to exit the grid sometimes :( 
            //because it stops the player from trapping the fly, I think it is worth keeping this fix even though it's sloppy
        }
        else Direction = choiceWeight[random];

        //Move the fly
        if(Direction == 1)
        {
            transform.Translate(0, 0, 1);
        }

        if(Direction == 2)
        {
            transform.Translate(1, 0, 0);
        }

        if(Direction == 3)
        {
            transform.Translate(0, 0, -1);
        }

        if(Direction == 4)
        {
            transform.Translate(-1, 0, 0);
        }
        
    }

    public void resetChoices()
    {
        //reset the list
        while(choiceWeight.Count > 0)
        {
            choiceWeight.RemoveAt(0);
        }
    }
}
