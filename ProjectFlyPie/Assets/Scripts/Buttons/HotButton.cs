using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotButton : MonoBehaviour
{
    public FlyDecider flyChoice;
    public GMData data;

    public void OnClick()
    {
        //Gets information about the Fly's last move
        flyChoice = GameObject.FindObjectOfType<FlyDecider>();
        data = GameObject.FindObjectOfType<GMData>();
        data.hasAnswered = true;

        //These IF statements remove the number from choiceWeight that represents the opposite direction of the Fly's last movement
        
        //Don't go to 3 (direction of "backward" raycast)
        if (flyChoice.Direction == 1) 
        {
            flyChoice.choiceWeight.RemoveAll(x => x == 3); //because forward is hot, we can assume backwards is 'cold'
        }

        //Don't go to 1 (direction of "forward" raycast)
        if (flyChoice.Direction == 3)
        {
            flyChoice.choiceWeight.RemoveAll(x => x == 1); //because backwards is hot, we can assume forwards is 'cold'
        }

        //Don't go to 4 (direction of "left" raycast)
        if (flyChoice.Direction == 2)
        {
            flyChoice.choiceWeight.RemoveAll(x => x == 4); //because right is hot, we can assume left is 'cold'
        }

        //Don't go to 2(direction of "right" raycast)
        if (flyChoice.Direction == 4)
        {
            flyChoice.choiceWeight.RemoveAll(x => x == 2); //because left is hot, we can assume right is 'cold'
        }
    }
}
