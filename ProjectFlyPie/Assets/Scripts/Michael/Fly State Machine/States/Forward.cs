using UnityEngine;

public class Forward : FlyBaseState
{
    public override void EnterState(FlyStateManager fly)
    {
        Debug.Log("the fly moved forward");
    }

    public override void UpdateState(FlyStateManager fly)
    {

    }
}
