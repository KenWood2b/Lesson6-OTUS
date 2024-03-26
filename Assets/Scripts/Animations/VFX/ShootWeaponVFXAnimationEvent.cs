using Components;
using UnityEngine;

namespace Animations.VFX
{
    public sealed class ShootWeaponVFXAnimationEvent : MonoBehaviour
    {
        [SerializeField] private AttackComponent _attackComponent;
        [SerializeField] private AnimationEventListener animationEventListener;
        [SerializeField] private ParticleSystem vfx;
        private const string Fire_event = "fire_event";


        /*
         *  В рамках данного ДЗ никакие VFX не назначаются и не используются,
         *  но должен быть реализовано вывод в консоль сообщение типа:
         *  "[ShootWeaponVFXAnimationEvent]: ShootVFX()",
         *   когда происходит выстрел (для отображения вспышки выстрела)
         *  Скрипт должен быть на соответствующем объекте в оружие
         */
        private void OnEnable()
        {
            animationEventListener.OnMessageReceived += PlayShootVFX;
        }

        private void OnDisable()
        {
            animationEventListener.OnMessageReceived -= PlayShootVFX;
        }

        private void PlayShootVFX(string message)
        {
            if (string.Equals(message, Fire_event))
            {
                vfx.Play(true);
            }
        }
    }
}