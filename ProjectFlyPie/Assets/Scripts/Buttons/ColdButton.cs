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
        //gets the last move the Fly made(flyChoice)
        flyChoice = GameObject.FindObjectOfType<FlyDecider>();
        data = GameObject.FindObjectOfType<GMData>();
        data.hasAnswered = true;
        
        //The following IF statements eliminate, from the choiceWieght list, the entries numbered the same as the last move
        //This takes away the ability of the fly to randomly choose the same direction that was just deemed "cold" by player
        
        //Don't go to 1(direction of "forward" raycast)
        if(flyChoice.Direction == 1)
        {
            for(var i = 0; i<flyChoice.choiceWeight.Count; i++)
            {
                if(flyChoice.choiceWeight[i] == 1)
                {
                    flyChoice.choiceWeight.RemoveAt(i);
                    break;
                }
            }
            /*
            //  don't go to 1
            foreach(int value in flyChoice.choiceWeight)
            {
                if(value == 1)
                {
                    while(flyChoice.choiceWeight.Contains(1))
                    {
                        flyChoice.choiceWeight.Remove(value);
                        return;
                    }
                }
            }
            */
        }

        //Don't go to 3(direction of "backward" raycast)
        if(flyChoice.Direction == 3)
        {
            for(var i = 0; i<flyChoice.choiceWeight.Count; i++)
            {
                if(flyChoice.choiceWeight[i] == 3)
                {
                    flyChoice.choiceWeight.RemoveAt(i);
                    break;
                }
            }
            /*
            //  don't go to 3
            foreach(int value in flyChoice.choiceWeight)
            {
                if(value == 3)
                {
                    while (flyChoice.choiceWeight.Contains(3))
                    {
                        flyChoice.choiceWeight.Remove(value);
                        return;
                    }
                }
            }
            */

        }

        //Don't go to 2(direction of "right" raycast)
        if(flyChoice.Direction == 2)
        {
            for(var i = 0; i<flyChoice.choiceWeight.Count; i++)
            {
                if(flyChoice.choiceWeight[i] == 2)
                {
                    flyChoice.choiceWeight.RemoveAt(i);
                    break;
                }
            }
            /*
            //  don't go to 2
            foreach(int value in flyChoice.choiceWeight)
            {
                if(value == 2)
                {
                    while (flyChoice.choiceWeight.Contains(2))
                    {
                        flyChoice.choiceWeight.Remove(value);
                        return;
                    }
                }
            }
            */
        }

        //Don't go to 4(direction of "left" raycast)
        if(flyChoice.Direction == 4)
        {
            for(var i = 0; i<flyChoice.choiceWeight.Count; i++)
            {
                if(flyChoice.choiceWeight[i] == 4)
                {
                    flyChoice.choiceWeight.RemoveAt(i);
                    break;
                }
            }
            /*
            //don't go to 4
            foreach(int value in flyChoice.choiceWeight)
            {
                if(value == 4)
                {
                    while (flyChoice.choiceWeight.Contains(4))
                    {
                        flyChoice.choiceWeight.Remove(value);
                        return;
                    }
                }
            }
            */
        }


    }
}
