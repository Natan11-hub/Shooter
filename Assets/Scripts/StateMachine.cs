public class StateMachine
{
    protected State CurrentState { get; private set; }

    public void InitializeState(State startingState)
    {
        CurrentState = startingState;
        CurrentState.Enter();
    }

    public void ChangeState(State changeState)
    {
        CurrentState?.Exit();

        CurrentState = changeState;
        CurrentState.Enter();
    }
}
