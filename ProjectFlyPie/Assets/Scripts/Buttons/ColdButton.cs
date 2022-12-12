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
        heatReducer.HeatValue = 0;
        flyChoice = GameObject.FindObjectOfType<FlyDecider>();
        data = GameObject.FindObjectOfType<GMData>();
        data.hasAnswered = true;
        
        if(flyChoice.Direction == 1)
        {
            //  don't go to 1
            foreach(int value in flyChoice.choiceWeight)
            {
                if(value == 1)
                {
                    while(flyChoice.choiceWeight.Contains(1))
                    {

                        Debug.Log(value + " was removed");
                        flyChoice.choiceWeight.Remove(value);
                        return;
                    }
                }
            }
        }
        
        if(flyChoice.Direction == 3)
        {
            //  don't go to 3
            foreach(int value in flyChoice.choiceWeight)
            {
                if(value == 3)
                {
                    while (flyChoice.choiceWeight.Contains(3))
                    {

                        Debug.Log(value + " was removed");
                        flyChoice.choiceWeight.Remove(value);
                        return;
                    }
                }
            }

        }
        if(flyChoice.Direction == 2)
        {
            //  don't go to 2
            foreach(int value in flyChoice.choiceWeight)
            {
                if(value == 2)
                {
                    while (flyChoice.choiceWeight.Contains(2))
                    {

                        Debug.Log(value + " was removed");
                        flyChoice.choiceWeight.Remove(value);
                        return;
                    }
                }
            }
        }
        if(flyChoice.Direction == 4)
        {
            //don't go to 4
            foreach(int value in flyChoice.choiceWeight)
            {
                if(value == 4)
                {
                    while (flyChoice.choiceWeight.Contains(4))
                    {

                        Debug.Log(value + " was removed");
                        flyChoice.choiceWeight.Remove(value);
                        return;
                    }
                }
            }
        }


    }
}
