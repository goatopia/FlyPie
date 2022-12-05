using UnityEngine;

public class GMStateManager : MonoBehaviour
{
    GMBaseState currentState;

    public Initial initial = new Initial();
    public Poll poll = new Poll();
    public Move move = new Move();

    private void Start()
    {
        currentState = initial;
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void switchState(GMBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
