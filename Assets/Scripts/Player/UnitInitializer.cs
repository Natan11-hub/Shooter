using UnityEngine;
using UnityEngine.UI;

namespace Unit
{
    public class UnitInitializer : MonoBehaviour
    {
        [SerializeField] private UnitView unitPrefab;
        [SerializeField] private Slider _unitHealthbar;
        private UnitPresenter _unitPresenter;
        private int _unitMaxHealth = 100;
        private float _initialSpeed = 5f;
        private float _maxSpeed = 8f;

        private void Start()
        {
            var unitView = Instantiate(unitPrefab);
            unitView.SetHealthbar(_unitHealthbar);

            var unitModel = new UnitModel(_unitMaxHealth, _initialSpeed, _maxSpeed);
            _unitPresenter = new UnitPresenter(unitModel, unitView);
        }

        private void OnDestroy()
        {
            _unitPresenter.Dispose();
        }
    }
}