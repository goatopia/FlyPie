using UnityEngine;

public class Initial : GMBaseState
{
    public override void EnterState(GMStateManager manager)
    {
        Debug.Log("Current state: Initial");
        UI_Canvas = GameObject.FindGameObjectWithTag("UI");
        UI_Canvas.transform.GetChild(1).gameObject.SetActive(true); //player can click anywhere to start
    }

    public override void UpdateState(GMStateManager manager)
    {
        data = GameObject.FindObjectOfType<GMData>();
        if(data.hasStarted == true) //if the game has started, do this
        {
            UI_Canvas.transform.GetChild(1).gameObject.SetActive(false); //disable the button which starts the game
            flyChoice = GameObject.FindObjectOfType<FlyDecider>(); //we need to have to fly gather some information about its environment
            if(data.regulator == 0) //the fly will make an initial move before accepting player input
            {
            flyChoice.LookAround();
            flyChoice.moveFly();
            data.regulator += 1;
            }
            manager.switchState(manager.move);
        }
        else return;
    }
}
