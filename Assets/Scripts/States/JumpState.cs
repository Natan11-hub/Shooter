using Services;
using Unit;

namespace DefaultNamespace.States
{
    public class JumpState : PlayerControllerState
    {
        private IUnitInput _unitInput;
        public JumpState(UnitController unitController, IUnitInput unitInput,StateMachine stateMachine) : base(unitController, stateMachine)
        {
        }

        public override void Enter()
        {
            unitController.Jump();
        }

        public override void Exit()
        {
            
        }

        public override void Update()
        {
            if(!unitController.IsGrounded() && !_unitInput.IsJumped)
                stateMachine.ChangeState(new StandingState(unitController, _unitInput, stateMachine));
        }
    }
}