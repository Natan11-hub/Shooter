using Unit;
using UnityEngine;

public abstract class PlayerControllerState : State
{
    protected PlayerController _playerController;
    
    protected PlayerControllerState(PlayerController playerController, StateMachine stateMachine) : base(stateMachine)
    {
        _playerController = playerController;
    }
}
