using UnityEngine;

namespace Animations.VFX
{
    public sealed class DeathVFXAnimationEvent : MonoBehaviour
    {
        [SerializeField] private AnimationEventListener animationEventListener;
        [SerializeField] private ParticleSystem vfx;
        private const string Death_event = "death_event";
        /*
         *  В рамках данного ДЗ никакие VFX не назначаются и не используются,
         *  но должен быть реализовано вывод в консоль сообщение типа:
         *  "[DeathVFXAnimationEvent]: PlayBloodVFX()",
         *   когда происходит получения урона
         *   Скрипт должен быть на соответствующем объекте в персонаже
         */
        private void OnEnable()
        {
            animationEventListener.OnMessageReceived += PlayDeathVFX;
        }

        private void OnDisable()
        {
            animationEventListener.OnMessageReceived -= PlayDeathVFX;
        }

        private void PlayDeathVFX(string message)
        {
            if (string.Equals(message, Death_event))
            {
                Debug.Log("The player died");
            }
        }
    }
}