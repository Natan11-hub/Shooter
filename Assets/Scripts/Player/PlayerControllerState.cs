using Unit;
using UnityEngine;

public abstract class PlayerControllerState : State
{
    protected UnitController unitController;
    
    protected PlayerControllerState(UnitController unitController, StateMachine stateMachine) : base(stateMachine)
    {
        this.unitController = unitController;
    }
}
