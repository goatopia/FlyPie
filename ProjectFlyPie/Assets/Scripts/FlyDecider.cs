using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDecider : MonoBehaviour
{
    //next two lines were just for testing, may repurpose later -CAC
    //private float speed = 0.5f;
    //private float RotSpd = 5.5f;
    //private List<int> choiceWeight = new List<int>();
    private int Heat;
    private int Direction;

    //later, the Update method will modify the fly's options(by eliminating a direction) when the player
    // clicks either "warm" or "cold". For now, I am just using a key press to simulate this. -CAC
    void Update()
    {
        //The following two lines were for testing whether or not the fly changed the heat values by moving to new grid spaces -CAC
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //transform.Rotate(Vector3.up * (RotSpd * Time.deltaTime));
                
        if(Input.GetKeyDown("space"))
        {
            RayForward();
            //RayRight();
            //RayBackward();
            //RayLeft();

            //Randomly selects a list entry from "choiceWeight" -CAC
            // Direction = Random.Range(0,Direction.Count);
            

        }
    }



    //the following 4 methods are meant to get the Heat Value of the grid space the raycasts hit and
    // then to add that number of either 1's-4's(1=forward, 2=right, 3=back, 4=left) to the list: "choiceWeight"
    // "choiceWeight" will then have a random element chosen which will be a number between 1-4
    // that determines the direction the fly moves -CAC

    void RayForward()
    {
        Ray ray1 = new Ray(transform.position, transform.forward);
        RaycastHit hitData;
        if(Physics.Raycast(ray1, hit))
        {
            var heatManager : HeatManager = hit.collider.GetComponent(HeatManager);
            if (heatManager != null)
            {
                Heat = heatManager.HeatDetect;
                Debug.Log("Heat = " + Heat);
            }
        }
        
        //for(int i = 0, i < Heat, i++)
        //{
        //    choiceWeight.Add(1);
        //}
        //Debug.Log
    }

    /* testing the above before I continue -CAC
    void RayRight()
    {
        Ray ray2 = new Ray(transform.position, transform.right);
        RaycastHit hitData;
        if(Physics.Raycast(ray2, out hitData))
        {

        }
    }

    void RayBackward()
    {
        Ray ray3 = new Ray(transform.position, transform.back);
        RaycastHit hitData;
        if (Physics.Raycast(ray2, out hitData))
        {

        }
    }

    void RayLeft()
    {
        Ray ray4 = new Ray(transform.position, transform.left);
        RaycastHit hitData;
        if (Physics.Raycast(ray2, out hitData))
        {

        }
    }
    */
}
