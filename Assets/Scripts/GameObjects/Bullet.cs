using Components;
using UnityEngine;

namespace GameObjects
{
    public sealed class Bullet : MonoBehaviour
    {
        [SerializeField]
        private int damage = 1;
        
        private void OnCollisionEnter(Collision other)
        {
            HealthComponent healthComponent = other.gameObject.GetComponentInParent<HealthComponent>();
            
            if (healthComponent != null)
            {
                healthComponent.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}