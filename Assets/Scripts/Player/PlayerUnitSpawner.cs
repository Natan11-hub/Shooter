using System;
using UnityEngine;

namespace Unit
{
    public class PlayerUnitSpawner : MonoBehaviour
    {
        [SerializeField] private UnitController _unitPrefab;
        private UnitHealthbar _unitHealthbar;

        private void Awake()
        {
            var unit = Instantiate(_unitPrefab);
            _unitHealthbar.SetUnit(unit);
        }
    }
}