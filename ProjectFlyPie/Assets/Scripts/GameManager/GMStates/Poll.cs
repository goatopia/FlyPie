using UnityEngine;

public class Poll : GMBaseState
{
    public override void EnterState(GMStateManager manager)
    {
        Debug.Log("Current State: Poll");

        //enable ui (allow the player to press the buttons)
        UI_Canvas = GameObject.FindGameObjectWithTag("UI");
        UI_Canvas.transform.GetChild(0).gameObject.SetActive(true);
    }

    public override void UpdateState(GMStateManager manager)
    {
        data = GameObject.FindObjectOfType<GMData>();
        if(data.regulator == 0)
        {
            manager.switchState(manager.initial);
        }
        else if(data.hasAnswered == true) //once the player has submitted feedback, change state back to move
        {
            flyChoice = GameObject.FindObjectOfType<FlyDecider>();
            flyChoice.moveFly();
            manager.switchState(manager.move);
        }
    }
}
