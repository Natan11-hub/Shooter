using Unit;
using UnityEngine;
using UnityEngine.UI;

public class UnitHealthbar : MonoBehaviour
{
    [SerializeField] private Slider _healthbar;
    private UnitController _unitPrefab;
    
    public void SetUnit(UnitController unit)
    {
        _unitPrefab = unit;
    }

    private void Update()
    {
        if (_unitPrefab == null)
            return;

        _healthbar.maxValue = _unitPrefab.MaxHealth;
        _healthbar.value = _unitPrefab.CurrentHealth;
    }
}
