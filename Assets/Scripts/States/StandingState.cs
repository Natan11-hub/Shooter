using Services;
using Unit;
using UnityEngine;

namespace DefaultNamespace.States
{
    public class StandingState : PlayerControllerState
    {
        public InputService inputService;
        
        public StandingState(PlayerController playerController,InputService inputService, StateMachine stateMachine) : base(playerController, stateMachine)
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
            _playerController.Standing();
            
            var movement = inputService.CheckMove();
            var jump = inputService.IsJumped();
            
            if(movement != Vector3.zero)
                stateMachine.ChangeState(new MovingState(_playerController,inputService, stateMachine));
            if(jump)
                stateMachine.ChangeState(new JumpState(_playerController, inputService, stateMachine));
        }
    }
}