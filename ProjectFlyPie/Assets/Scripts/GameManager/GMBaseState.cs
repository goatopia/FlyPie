using UnityEngine;

public abstract class GMBaseState
{
    public GameObject UI_Canvas;
    public FlyDecider flyChoice;
    public GMData data;

    public abstract void EnterState(GMStateManager manager);

    public abstract void UpdateState(GMStateManager manager);
}
