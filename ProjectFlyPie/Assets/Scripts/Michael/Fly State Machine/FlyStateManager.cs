using UnityEngine;

public class FlyStateManager : MonoBehaviour
{
    public FlyBaseState currentState;

    public Forward one = new Forward();
    public Right two = new Right();
    public Backward three = new Backward();
    public Left four = new Left();

    private void Start()
    {
        currentState = one;
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void switchState(FlyBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
