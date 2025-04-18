namespace Weapon
{
    public class WeaponModel
    {
        private float _firingRate;
        private float _damage;
        private float _range;

        public WeaponModel(float firingRate, float damage, float range)
        {
            _firingRate = firingRate;
            _damage = damage;
            _range = range;
        }
    }
}