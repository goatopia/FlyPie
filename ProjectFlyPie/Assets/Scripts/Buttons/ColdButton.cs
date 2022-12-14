using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdButton : MonoBehaviour
{
    public FlyDecider flyChoice;
    public GMData data;
    public HeatManager heatValue;
    public FlyCollider tile;
    public HeatManager heatReducer;

    public void OnClick()
    {
        //gets the tile the fly is currently on and reduces the heat value of it by 2 if the Cold Button is clicked
        tile = GameObject.FindObjectOfType<FlyCollider>();
        heatReducer = tile.tileName.GetComponent<HeatManager>();
        heatReducer.HeatValue -= 2;

        //Gets information about the Fly's last move
        flyChoice = GameObject.FindObjectOfType<FlyDecider>();

        //Send information to the game manager
        data = GameObject.FindObjectOfType<GMData>();
        data.hasAnswered = true;
        
        //The following IF statements eliminate, from the choiceWieght list, the entries numbered the same as the last move
        //This takes away the ability of the fly to randomly choose the same direction that was just deemed "cold" by player
        
        //Don't go to 1 (direction of "forward" raycast)
        if(flyChoice.Direction == 1)
        {
            flyChoice.choiceWeight.RemoveAll(x => x == 1); //because forward is cold, don't go forward again
        }

        //Don't go to 3(direction of "backward" raycast)
        if(flyChoice.Direction == 3)
        {
            //Don't go to 3
            flyChoice.choiceWeight.RemoveAll(x => x == 3); //because backwards is cold, don't go backwards again
        }

        //Don't go to 2(direction of "right" raycast)
        if(flyChoice.Direction == 2)
        {
            //Don't go to 2
            flyChoice.choiceWeight.RemoveAll(x => x == 2); //because right is cold, don't go right again
        }

        //Don't go to 4(direction of "left" raycast)
        if(flyChoice.Direction == 4)
        {
            //Don't go to 4
            flyChoice.choiceWeight.RemoveAll(x => x == 4); //because left is cold, don't go left again
        }


    }
}
