using Services;
using Unit;

namespace DefaultNamespace.States
{
    public class JumpState : PlayerControllerState
    {
        public JumpState(PlayerController playerController,InputService inputService ,StateMachine stateMachine) : base(playerController, stateMachine)
        {
        }

        public override void Enter()
        {
            _playerController.Jump();
        }

        public override void Exit()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}