using Services;
using Unit;
using UnityEngine;

namespace DefaultNamespace.States
{
    public class StandingState : PlayerControllerState
    {
        private readonly IUnitInput _unitInput;
        
        public StandingState(UnitController unitController, IUnitInput unitInput, StateMachine stateMachine) : base(unitController, stateMachine)
        {
        }

        public override void Enter()
        {
            
        }

        public override void Exit()
        {
            
        }

        public override void Update()
        {
            unitController.Standing();

            var movement = _unitInput.MoveDirection;
            var jump = _unitInput.IsJumped;
            
            if(movement != Vector3.zero)
                stateMachine.ChangeState(new MovingState(unitController, _unitInput, stateMachine));
            if(jump)
                stateMachine.ChangeState(new JumpState(unitController, _unitInput, stateMachine));
        }
    }
}