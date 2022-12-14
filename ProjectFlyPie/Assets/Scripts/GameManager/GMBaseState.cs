using UnityEngine;

public abstract class GMBaseState
{
    public GameObject UI_Canvas; //canvas for the states to access and change depending on what is happening in game
    public FlyDecider flyChoice;
    public GMData data; //each state is able to store and access data from this script

    public abstract void EnterState(GMStateManager manager); //each state will do something when it first switches to that state

    public abstract void UpdateState(GMStateManager manager); //each state will have an update function
}
