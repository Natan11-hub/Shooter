using System;
using UnityEngine;

namespace Weapon
{
    public class WeaponView : MonoBehaviour
    {
        private event Action Shot;

        public void Gunshot(int damage)
        {
            Shot.Invoke();
        }

        public void ReloadWeapon()
        {
            
        }

        public void SwapWeapon()
        {
            
        }
    }
}