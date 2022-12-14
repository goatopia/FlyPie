using UnityEngine;

public class GMStateManager : MonoBehaviour
{
    GMBaseState currentState;

    public Initial initial = new Initial();
    public Poll poll = new Poll(); //collect information from the player
    public Move move = new Move(); //move the fly and collect information from the environment

    private void Start()
    {
        //the game starts in the initial state
        currentState = initial;
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void switchState(GMBaseState state) //call this to update the current state
    {
        currentState = state;
        state.EnterState(this);
    }
}
