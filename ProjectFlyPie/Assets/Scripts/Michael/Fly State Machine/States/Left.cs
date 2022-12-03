using UnityEngine;

public class Left : FlyBaseState
{
    public override void EnterState(FlyStateManager fly)
    {
        Debug.Log("the fly moved left");
    }

    public override void UpdateState(FlyStateManager fly)
    {

    }
}
