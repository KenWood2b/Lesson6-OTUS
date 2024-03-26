using System;
using Components;
using UnityEngine;

namespace Controllers
{
    public sealed class FireController : MonoBehaviour
    {
        /*
         *  реализовать выстрел через AttackComponent
         */
        [SerializeField]
        private GameObject character;

        [SerializeField]
        private AttackComponent _attackComponent;

        private void Awake()
        {
            {
                if (character != null)
                    _attackComponent = character.GetComponentInChildren<AttackComponent>();
            }
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _attackComponent.Shoot();
            }
        }
    }
}