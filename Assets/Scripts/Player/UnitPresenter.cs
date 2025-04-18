using System;

namespace Unit
{
    public class UnitPresenter : IDisposable
    {
        private UnitModel _model;
        private UnitView _view;

        public UnitPresenter(UnitModel model, UnitView view)
        {
            _model = model;
            _view = view;
            _model.OnChangedHealth += OnChangedHealth;
            _model.OnChangedSpeed += OnChangedSpeed;
            _view.Damaged += OnDamageView;
        }

        private void OnDamageView(int damage)
        {
            _model.TakeDamage(damage);
        }

        private void OnChangedHealth(int amount)
        {
            _view.SetHealth(amount);
        }

        private void OnChangedSpeed(float speed)
        {
            _view.SetSpeed(speed);
        }

        private void OnUpperSpeedView(float speed)
        {
            _model.UpperSpeed(speed);
        }

        private void OnLowerSpeedView(float speed)
        {
            _model.LowerSpeed(speed);
        }

        public void Dispose()
        {
            _model.OnChangedHealth -= OnChangedHealth;
        }
    }
}