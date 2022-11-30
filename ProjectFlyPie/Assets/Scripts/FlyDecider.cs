using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDecider : MonoBehaviour
{
    //next two lines were just for testing, may repurpose later -CAC
    //private float speed = 0.5f;
    //private float RotSpd = 5.5f;
    
    private List<int> choiceWeight = new List<int>();
    private int frontHeat;
    private int rightHeat;
    private int leftHeat;
    private int backHeat;
    private int Direction;

    //This is identical to the Update method, WITHOUT the user input consideration. This is so the Fly will make it's own first move. -CAC
    void Awake()
    {
        RayForward();
        RayRight();
        RayBackward();
        RayLeft();

        Direction = Random.Range(1, choiceWeight.Count);
        if (Direction == 1)
        {
            Debug.Log("Fly started with a forward move");
            transform.Translate(0, 0, 1);
        }

        if (Direction == 2)
        {
            Debug.Log("Fly started with a right move");
            transform.Translate(1, 0, 0);
        }

        if (Direction == 3)
        {
            Debug.Log("Fly started with a backward move");
            transform.Translate(0, 0, -1);
        }

        if (Direction == 4)
        {
            Debug.Log("Fly started with a left move");
            transform.Translate(-1, 0, 0);
        }
    }


    //later, the Update method will modify the fly's options(by eliminating a direction) when the player
    // clicks either "warm" or "cold". For now, I am just using a key press to simulate this. -CAC
    void Update()
    {
        //this if statement will *NEED TO BE AMMENDED* or removed and placed 
        //   will need to be changed to account for user input once we incorporate Steven's UI scripting
        if(Input.GetKeyDown("space"))
        {
            Debug.Log("space was pressed");
            RayForward();
            RayRight();
            RayBackward();
            RayLeft();

            //here is where we will remove either all 1's or 3's from the "choiceWeight" list.
            //    If player clicks "WARM", then 3's(backward) are removed
            //    If player clicks "COLD", then 1's(forward) are removed

            //Randomly selects a list entry from "choiceWeight" -CAC
            Direction = Random.Range(1, choiceWeight.Count);

            //if statements to follow which determine the transform/movement of the Fly -CAC
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
    }

    //the following 4 methods are meant to get the Heat Value of the grid space the raycasts hit and
    // then to add that number of either 1's-4's(1=forward, 2=right, 3=back, 4=left) to the list: "choiceWeight"
    // "choiceWeight" will then have a random element chosen which will be a number between 1-4
    // that determines the direction the fly moves -CAC
    void RayForward()
    {
        //sends out ray
        Ray ray1 = new Ray(transform.position, transform.forward);
        RaycastHit hitData;
        //checks to see if ray hit anything
        if(Physics.Raycast(ray1, out hitData))
        {
            //sets a private variable, "frontHeat", to equal the value of the HeatDetect variable of gameObject hit by ray
            frontHeat = hitData.collider.GetComponent<HeatManager>().HeatDetect;
            //loop that adds the number "1" to the list "choiceWeight" a number of times equal to the value of "HeatDetect"
            for (int i = 0; i < frontHeat; i++)
            {
                choiceWeight.Add(1);
            }
        }
    }
    
    void RayRight()
    {
        Ray ray2 = new Ray(transform.position, transform.right);
        RaycastHit hitData;
        if(Physics.Raycast(ray2, out hitData))
        {
            rightHeat = hitData.collider.GetComponent<HeatManager>().HeatDetect;
            for (int i = 0; i < rightHeat; i++)
            {
                choiceWeight.Add(2);
            }
        }
    }

    //testing the above before I continue -CAC
    
    
    void RayBackward()
    {
        Ray ray3 = new Ray(transform.position, -transform.forward);
        RaycastHit hitData;
        if (Physics.Raycast(ray3, out hitData))
        {
            backHeat = hitData.collider.GetComponent<HeatManager>().HeatDetect;
            for (int i = 0; i < backHeat; i++)
            {
                choiceWeight.Add(3);
            }
        }
    }

    void RayLeft()
    {
        Ray ray4 = new Ray(transform.position, -transform.right);
        RaycastHit hitData;
        if (Physics.Raycast(ray4, out hitData))
        {
            leftHeat = hitData.collider.GetComponent<HeatManager>().HeatDetect;
            for (int i = 0; i < leftHeat; i++)
            {
                choiceWeight.Add(4);
            }
        }
    }

}
