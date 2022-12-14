using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotButton : MonoBehaviour
{
    public FlyDecider flyChoice;
    public GMData data;

    public void OnClick()
    {
        //Gets the last move of the Fly
        flyChoice = GameObject.FindObjectOfType<FlyDecider>();
        data = GameObject.FindObjectOfType<GMData>();
        data.hasAnswered = true;

        //These IF statements remove the number from choiceWeight that represents the opposite direction of the Fly's last movement
        
        //Don't go to 3(direction of "backward" raycast)
        if (flyChoice.Direction == 1)
        {
            flyChoice.choiceWeight.RemoveAll(x => x == 3);
            /*
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

        //Don't go to 1(direction of "forward" raycast)
        if (flyChoice.Direction == 3)
        {
            flyChoice.choiceWeight.RemoveAll(x => x == 1);
            /*
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
                    while (flyChoice.choiceWeight.Contains(1))
                    {
                        flyChoice.choiceWeight.Remove(value);
                        return;
                    }
                }
            }
            */

        }

        //Don't go to 4(direction of "left" raycast)
        if (flyChoice.Direction == 2)
        {
            flyChoice.choiceWeight.RemoveAll(x => x == 4);
            /*
            for(var i = 0; i<flyChoice.choiceWeight.Count; i++)
            {
                if(flyChoice.choiceWeight[i] == 4)
                {
                    flyChoice.choiceWeight.RemoveAt(i);
                    break;
                }
            }
            /*
            //  don't go to 4
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

        //Don't go to 2(direction of "right" raycast)
        if (flyChoice.Direction == 4)
        {
            flyChoice.choiceWeight.RemoveAll(x => x == 2);
            /*
            for(var i = 0; i<flyChoice.choiceWeight.Count; i++)
            {
                if(flyChoice.choiceWeight[i] == 2)
                {
                    flyChoice.choiceWeight.RemoveAt(i);
                    break;
                }
            }
            /*
            //don't go to 2
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
    }
}
