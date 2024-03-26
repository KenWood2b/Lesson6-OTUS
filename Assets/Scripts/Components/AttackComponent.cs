using UnityEngine;

namespace Components
{
    public class AttackComponent : MonoBehaviour
    {
        /*
         * AttackComponent реагирует на действия пользователя и запускате анимацию выстрела, в том случае если выстрел возможен
         * 
         */

        private WeaponComponent _weaponComponent;

        private void Awake()
        {
            _weaponComponent = GetComponent<WeaponComponent>();
        }

        public void Shoot()
        {
            if (_weaponComponent.CanFire)
            {
                _weaponComponent.Fire();
            }
        }
    }
}