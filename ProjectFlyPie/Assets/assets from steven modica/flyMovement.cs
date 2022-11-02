using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creator: Steven Modica
//this script is for the use of ouside the users choice of picking if the prior movement was either hot/cold and after the user makes a decision on the
// fly's direction this script gets triggered to check for any warm arrows around the current space the fly is in before picking a random
// direction by assigning a random number between 1 and 4. whatever the random number makes within that parameter corresponds to what direction the fly 
// will fly towards.
public class flyMovement : MonoBehaviour
{
    int flySpawnPointX;
    int flySpawnPointY;

    int flySpawnPosition[];

    int flyPositionX;
    int flyPositionY;


    int randomNumber;

    bool isOnCupcake = false;
    bool isUpWarm = false;
    bool isRightWarm = false;
    bool isDownWarm = false;
    bool isLeftWarm = false;


    int flyMadeItToTheCupcake()
    {
        // Destroy this fly and respawn in another one.
    }

    // Start is called before the first frame update
    void Start()
    {
        //the asset will start off by making a fly spawn point by using random 10x10 coordinates

        flySpawnPointX = Random.Range(1, 10);
        flySpawnPointY = Random.Range(1, 10);

        // now the random coordinates has been made lets put them into the fly's spawn position
        flySpawnPosition[] = { flySpawnPointX, flySpawnPointY};

        // after the fly has spawned in that random location, the fly's x and y coordinates are implemented
        flyPositionX = flySpawnPointX;
        flyPositionY = flySpawnPointY;
    }

    // Update is called once per frame
    void Update()
    {
        //Overall, if the fly lands on the same tile as the cupcake the boolean breaks
        if (isOnCupcake == false)
        {

            //This if-else statement prioritizes if the direction is warm, then that will be the fly's direction automatically, if false do a random number instead
            if(isUpWarm == true)
            {
                Debug.Log("this fly went Up");
                // flySpawnPositionX++;
            }
            if(isLeftWarm == true)
            {
                Debug.Log("this fly went Left");
                // flySpawnPositionY++;
            }
            if (isDownWarm == true)
            {
                Debug.Log("this fly went Down");
                // flySpawnPositionX--;
            }
            if (isRightWarm == true)
            {
                Debug.Log("this fly went Right");
                // flySpawnPositionY--;
            }


            // If the fly is in a square that has no warm directions, then the random number will pick a number and whatever number it has will correlate the flys direction
            else
            {
                randomNumber = Random.Range(1, 4);
                
                switch(randomNumber)
                {
                    case 1:
                        Debug.Log("this fly went Up");
                        break;
                    case 2:
                        Debug.Log("this fly went Left");
                        break;
                    case 3:
                        Debug.Log("this fly went Down");
                        break;
                    case 4:
                        Debug.Log("this fly went Right");
                        break;
                }

            }



        }

        // when the fly makes it to the cupcake the boolean will change and returns this statement in line 25
        else { return flyMadeItToTheCupcake(); }

    }
}
