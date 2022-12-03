using UnityEngine;

public class Right : FlyBaseState
{
    public override void EnterState(FlyStateManager fly)
    {
        Debug.Log("the fly moved right");
    }

    public override void UpdateState(FlyStateManager fly)
    {

    }
}
