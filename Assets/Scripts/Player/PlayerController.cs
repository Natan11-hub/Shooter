using Services;
using UnityEngine;

namespace Unit
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private UnitView _uniView;
        [SerializeField] private InputService _inputService;
        private Rigidbody _rigidbody;

        public void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Update()
        {
            HandleMovement();
            HandleActions();
        }

        public void HandleMovement()
        {
            var movement = _inputService.CheckMove();

            _uniView.transform.Translate(movement * Time.deltaTime);
        }

        public void HandleActions()
        {
            if (_inputService.IsAttacked())
                HandleAttack();

            if (_inputService.IsJumped())
                HandleJump();
            if (_inputService.IsReloaded())
                HandleReload();
        }

        private void HandleReload()
        {
            //:b
        }

        private void HandleAttack()
        {
            //.|.
        }

        public void HandleJump()
        {
            _uniView.Jump(_rigidbody);
        }
    }
}