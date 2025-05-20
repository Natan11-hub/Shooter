using DefaultNamespace.States;
using Services;
using UnityEngine;

namespace Unit
{
    public class UnitController : MonoBehaviour
    {
        //SOundManaged ССЫЛКУ СЮДА БЛЯТЬ и Ссылку на аниматор
        [SerializeField] private GameObject checkGround;
        [SerializeField] private float _maxSpeed;
        [SerializeField] private int _maxHealth;
        [SerializeField] private LayerMask _mask;

        private float _currentHealth;
        private Rigidbody _rigidbody;
        private StateMachine _stateMachine;

        private bool _isControlledByPlayer;

        public float MaxHealth => _maxHealth;
        public float CurrentHealth => _currentHealth;

        public void Awake()
        {
            StateMachine stateMachine = new StateMachine();

            IUnitInput unitInput = _isControlledByPlayer
                ? new PlayerUnitInput(FindAnyObjectByType<InputService>())
                : new AIUnitInput();

            stateMachine.InitializeState(new StandingState(this, unitInput, stateMachine));
        }

        public void Move(Vector3 movement)
        {
            _rigidbody.velocity = movement * _maxSpeed;
        }

        public void Standing()
        {
            _rigidbody.velocity = Vector3.zero;
        }

        public void Jump()
        {
            _rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
        }

        public bool IsGrounded()
        {
            Collider[] colliders = Physics.OverlapSphere(checkGround.transform.position, 0.1f, _mask);
            if (colliders.Length > 0)
                return true;
            return false;
        }

        public void Shoot()
        {

        }

        public void Ducking()
        {

        }

        public void TakeDamage(float damage)
        {
            
        }
}
}