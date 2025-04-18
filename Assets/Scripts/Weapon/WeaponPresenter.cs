using UnityEngine;

namespace Weapon
{
    public class WeaponPresenter : MonoBehaviour
    {
        private WeaponModel _weaponModel;
        private WeaponView _weaponView;

        public WeaponPresenter(WeaponModel weaponModel, WeaponView weaponView)
        {
            _weaponModel = weaponModel;
            _weaponView = weaponView;
        }
    }
}