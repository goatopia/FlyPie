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
        tile = GameObject.FindObjectOfType<FlyCollider>();
        heatReducer = tile.tileName.GetComponent<HeatManager>();
        heatReducer.HeatValue -= 2;
        flyChoice = GameObject.FindObjectOfType<FlyDecider>();
        data = GameObject.FindObjectOfType<GMData>();
        data.hasAnswered = true;
        
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
