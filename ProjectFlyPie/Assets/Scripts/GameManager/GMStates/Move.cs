using UnityEngine;

public class Move : GMBaseState
{
    public override void EnterState(GMStateManager manager)
    {
        flyChoice = GameObject.FindObjectOfType<FlyDecider>();
        flyChoice.resetChoices();
        flyChoice.LookAround();


        Debug.Log("Current State: Move");

        //disable ui
        UI_Canvas = GameObject.FindGameObjectWithTag("UI");
        UI_Canvas.transform.GetChild(0).gameObject.SetActive(false);
    }

    public override void UpdateState(GMStateManager manager)
    {
        
        data = GameObject.FindObjectOfType<GMData>();
        data.hasAnswered = false;

        if(data.regulator == 0)
        {
            flyChoice = GameObject.FindObjectOfType<FlyDecider>();
            flyChoice.moveFly();
            data.regulator += 1;
        }

        else if(data.hasAnswered == false)
        {
            manager.switchState(manager.poll);
        }
    }
}
