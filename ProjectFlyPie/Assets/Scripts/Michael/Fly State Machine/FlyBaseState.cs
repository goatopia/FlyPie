using UnityEngine;

public abstract class FlyBaseState
{
    public abstract void EnterState(FlyStateManager fly);

    public abstract void UpdateState(FlyStateManager fly);
}
