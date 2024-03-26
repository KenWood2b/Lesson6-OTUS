using Components;
using UnityEngine;

namespace Animations
{
    [RequireComponent(typeof(Animator))]
    public sealed class ShootAnimatorTrigger : MonoBehaviour
    {

        /*
         * Должен управлять анимационным событием выстрела
         */

        [SerializeField]
        private WeaponComponent shootComponent;

        private Animator _animator;

        private static readonly int Shoot = Animator.StringToHash("Shoot");

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void OnEnable()
        {
            shootComponent.OnFire += SetShootTrigger;
        }

        private void OnDisable()
        {
            shootComponent.OnFire -= SetShootTrigger;
        }

        private void SetShootTrigger()
        {
            _animator.SetTrigger(Shoot);
        }
    }
}