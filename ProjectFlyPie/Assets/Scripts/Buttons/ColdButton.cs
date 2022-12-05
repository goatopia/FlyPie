using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdButton : MonoBehaviour
{
    public FlyDecider flyChoice;
    public GMData data;

    public void OnClick()
    {
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
                    Debug.Log(value + " was removed");
                    flyChoice.choiceWeight.RemoveAt(value);
                    return;
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
                    Debug.Log(value + " was removed");
                    flyChoice.choiceWeight.RemoveAt(value);
                    return;
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
                    Debug.Log(value + " was removed");
                    flyChoice.choiceWeight.RemoveAt(value);
                    return;
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
                    Debug.Log(value + " was removed");
                    flyChoice.choiceWeight.RemoveAt(value);
                    return;
                }
            }
        }
    }
}
