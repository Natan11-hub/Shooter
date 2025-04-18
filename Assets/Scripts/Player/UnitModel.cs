using System;
using UnityEngine;

namespace Unit
{
    public class UnitModel
    {
        public event Action<int> OnChangedHealth;
        public event Action<float> OnChangedSpeed;
        
        private int _maxHealth;
        private int _currentHealth;
        private float _minSpeed;
        private float _maxSpeed;

        public int MaxHealth => _maxHealth;
        public int CurrentHealth => _currentHealth;
        public float MinSpeed => _minSpeed;
        public float MaxSpeed => _maxSpeed;


        public bool IsDead => _currentHealth <= 0;

        public UnitModel(int maxHealth, float initialMinSpeed, float maxSpeed)
        {
            _maxHealth = maxHealth;
            _currentHealth = _maxHealth;
            _minSpeed = initialMinSpeed;
            _maxSpeed = maxSpeed;
        }

        public void TakeDamage(int amount)
        {
            if (amount < 0)
                throw new Exception("Входящий урон меньше нуля.");
            
            _currentHealth = Mathf.Max(0, _currentHealth - amount);
            OnChangedHealth?.Invoke(_currentHealth);
        }

        public void Heal(int amount)
        {
            if (amount < 0)
                throw new Exception("Лечение менее нуля.");
            
            _currentHealth += amount;
            if (_currentHealth > _maxHealth)
                _currentHealth = _maxHealth;
            OnChangedHealth?.Invoke(_currentHealth);
        }

        public void UpperSpeed(float speed)
        {
            _minSpeed += speed;
            OnChangedSpeed.Invoke(_minSpeed);
        }

        public void LowerSpeed(float speed)
        {
            _minSpeed -= speed;
            OnChangedSpeed.Invoke(_minSpeed);
        }
    }
}