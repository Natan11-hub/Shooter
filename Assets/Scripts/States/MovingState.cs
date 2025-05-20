using System.Numerics;
using Services;
using Unit;
using Vector3 = UnityEngine.Vector3;

namespace DefaultNamespace.States
{
    public class MovingState : PlayerControllerState
    {
        private IUnitInput _unitInput;
        public MovingState(UnitController unitController, IUnitInput unitInput, StateMachine stateMachine) : base(unitController, stateMachine)
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
            if (unitController.IsGrounded())
                stateMachine.ChangeState(new JumpState(unitController, _unitInput, stateMachine));
            if(_unitInput.MoveDirection == Vector3.zero)
                stateMachine.ChangeState(new StandingState(unitController, _unitInput, stateMachine));
        }
    }
}