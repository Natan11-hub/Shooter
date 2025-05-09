using DefaultNamespace.States;
using Services;
using UnityEngine;

namespace Unit
{
    public class PlayerController : MonoBehaviour
    {
        //SOundManaged ССЫЛКУ СЮДА БЛЯТЬ и Ссылку на аниматор
        [SerializeField] private UnitView _unitView;
        [SerializeField] private InputService _inputService;
        [SerializeField] private GameObject checkGround;
        private Rigidbody _rigidbody;
        private LayerMask _mask;

        public void Awake()
        {
            _mask = LayerMask.GetMask("Player");
            StateMachine stateMachine = new StateMachine();
            stateMachine.InitializeState(new StandingState(this, _inputService, stateMachine));
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move(Vector3 movement)
        {
            _rigidbody.velocity = movement;
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
    }
}