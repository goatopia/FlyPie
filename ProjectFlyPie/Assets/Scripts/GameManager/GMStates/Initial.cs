using UnityEngine;

public class Initial : GMBaseState
{
    public override void EnterState(GMStateManager manager)
    {
        Debug.Log("Current state: Initial");
        UI_Canvas = GameObject.FindGameObjectWithTag("UI");
        UI_Canvas.transform.GetChild(1).gameObject.SetActive(true);
    }

    public override void UpdateState(GMStateManager manager)
    {
        data = GameObject.FindObjectOfType<GMData>();
        if(data.hasStarted == true)
        {
            UI_Canvas.transform.GetChild(1).gameObject.SetActive(false);
            flyChoice = GameObject.FindObjectOfType<FlyDecider>();
            if(data.regulator == 0)
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
