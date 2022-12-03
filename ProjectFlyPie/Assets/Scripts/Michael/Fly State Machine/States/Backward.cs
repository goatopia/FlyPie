using UnityEngine;

public class Backward : FlyBaseState
{
    public override void EnterState(FlyStateManager fly)
    {
        Debug.Log("the fly moved backward");
    }

    public override void UpdateState(FlyStateManager fly)
    {
        
    }
}
