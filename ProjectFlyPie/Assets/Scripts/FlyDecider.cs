using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDecider : MonoBehaviour
{
    //where we ultimately decide to go
    public int Direction;

    //weighted list used to choose a direction
    [SerializeField] private List<int> choiceWeight = new List<int>();

    //exclude the fly from being hit by our raycasts
    private int layerMask = 1 << 8;

    void Awake()
    {
        //compile the list
        LookAround();

        //choose a direction
        Move();
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            //reset the list
            resetChoices();
            
            Debug.Log("space was pressed");
            LookAround();

            //Take hot cold feedback?

            Move();
        }
    }

        void LookAround()
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
        
            Debug.Log("Forward value is " + heatManager.HeatValue);
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

            Debug.Log("Right value is " + heatManager.HeatValue);
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

            Debug.Log("Backward value is " + heatManager.HeatValue);
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

            Debug.Log("Left value is " + heatManager.HeatValue);
            for(int i = 0; i < heatManager.HeatValue; i++)
            {
                choiceWeight.Add(4);
            }     
        }
    }

    void Move()
    {
        //Select a direction from the list at random
        int random = Random.Range(0, choiceWeight.Count);
        Direction = choiceWeight[random];

        //Move the fly
        if(Direction == 1)
        {
            Debug.Log("FORWARD WAS CHOSEN");
            transform.Translate(0, 0, 1);
        }

        if(Direction == 2)
        {
            Debug.Log("RIGHT WAS CHOSEN");
            transform.Translate(1, 0, 0);
        }

        if(Direction == 3)
        {
            Debug.Log("BACKWARDS WAS CHOSEN");
            transform.Translate(0, 0, -1);
        }

        if(Direction == 4)
        {
            Debug.Log("LEFT WAS CHOSEN");
            transform.Translate(-1, 0, 0);
        }
    }

    void resetChoices()
    {
        //reset the list
        while(choiceWeight.Count > 0)
        {
            choiceWeight.RemoveAt(0);
        }
    }
}
