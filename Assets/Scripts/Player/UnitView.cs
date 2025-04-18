using System;
using Services;
using UnityEngine;
using UnityEngine.UI;

namespace Unit
{
    public class UnitView : MonoBehaviour
    {
        public event Action<int> Damaged;
        public event Action<int> Healed;
        public event Action<float> ChangeSpeed;

        [SerializeField] private Slider _healthbar;
        private InputService _inputService;

        public void SetHealth(int value)
        {
            _healthbar.value = value;
        }

        public void SetHealthbar(Slider slider)
        {
            if (slider == null)
                throw new Exception();
            _healthbar = slider;
        }

        public void TakeDamage(int damage)
        {
            Damaged.Invoke(damage);
        }

        public void TakeHeal(int heal)
        {
            Healed.Invoke(heal);
        }

        public void SetSpeed(float speed)
        {
            ChangeSpeed.Invoke(speed);
        }

        public void Attack()
        {
            //хрясь
        }

        public void Jump(Rigidbody rigidbody)
        {
            rigidbody.AddForce(0, 0, 5, ForceMode.Impulse);
        }
    }
}