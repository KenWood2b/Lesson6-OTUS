using UnityEngine;

namespace Animations.VFX
{
    public sealed class BloodDamageVFXAnimationEvent : MonoBehaviour
    {
        [SerializeField] private AnimationEventListener animationEventListener;
        [SerializeField] private ParticleSystem vfx;
        private const string Damage_event = "damage_event";
        /*
         *  В рамках данного ДЗ никакие VFX не назначаются и не используются,
         *  но должен быть реализовано вывод в консоль сообщение типа:
         *  "[BloodDamageVFXAnimationEvent]: PlayDeathVFX()",
         *   когда происходит получения урона
         *   Скрипт должен быть на соответствующем объекте в персонаже
         */

        private void OnEnable()
        {
            animationEventListener.OnMessageReceived += PlayBloodVFX;
        }

        private void OnDisable()
        {
            animationEventListener.OnMessageReceived -= PlayBloodVFX;
        }

        private void PlayBloodVFX(string message)
        {
            if (string.Equals(message, Damage_event))
            {
                vfx.Play(true);
            }
        }
    }
}