using Services;
using UnityEngine;

namespace Unit
{
    public class PlayerUnitInput : IUnitInput
    {
        private InputService _inputService;

        public PlayerUnitInput(InputService inputService)
        {
            _inputService = inputService;
        }

        public Vector3 MoveDirection => _inputService.CheckMove();
        public bool IsAttacked => _inputService.IsAttacked();
        public bool IsJumped => _inputService.IsJumped();
    }
}