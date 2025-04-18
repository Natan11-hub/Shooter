using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Weapon
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField] private GameObject _spawnPoint;
        [SerializeField] private float _firingRate;
        [SerializeField] private float _damage;
        [SerializeField] private float _range;
        [SerializeField] private WeaponView _weaponPrefab;
        
        private void Start()
        {
            var weaponModel = new WeaponModel(_firingRate, _damage, _range);
            
            WeaponView weaponView = Instantiate(_weaponPrefab,_spawnPoint.transform);
            WeaponPresenter presenter = new WeaponPresenter(weaponModel, weaponView);
        }
    }
}