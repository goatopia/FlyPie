using UnityEngine;

public class Move : GMBaseState
{
    public override void EnterState(GMStateManager manager)
    {
        flyChoice = GameObject.FindObjectOfType<FlyDecider>();
        flyChoice.resetChoices(); //clear the list of available moves
        flyChoice.LookAround(); //collect new environment data


        Debug.Log("Current State: Move");

        //disable ui (prevents the player from pressing the buttons more than they should)
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
            data.regulator += 1; //had an issue where the fly was moving twice sometimes, so the regulator int prevents this
        }

        else if(data.hasAnswered == false)
        {
            manager.switchState(manager.poll);
        }
    }
}
