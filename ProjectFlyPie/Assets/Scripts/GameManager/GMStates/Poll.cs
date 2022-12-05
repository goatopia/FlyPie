using UnityEngine;

public class Poll : GMBaseState
{
    public override void EnterState(GMStateManager manager)
    {
        Debug.Log("Current State: Poll");
        //enable ui
        UI_Canvas = GameObject.FindGameObjectWithTag("UI");
        UI_Canvas.transform.GetChild(0).gameObject.SetActive(true);
    }

    public override void UpdateState(GMStateManager manager)
    {
        data = GameObject.FindObjectOfType<GMData>();
        if(data.hasAnswered == true)
        {
            flyChoice = GameObject.FindObjectOfType<FlyDecider>();
            flyChoice.moveFly();
            manager.switchState(manager.move);
        }
    }
}
