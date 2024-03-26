using UnityEngine;

namespace Components
{
    [RequireComponent(typeof(Rigidbody))]
    public sealed class MoveComponent : MonoBehaviour
    {
        [SerializeField]
        private Vector3 moveDirection;

        [SerializeField]
        private float moveSpeed;

        public Vector3 MoveDirection
        {
            get => moveDirection;
            set => moveDirection = value;
        }

        public bool IsMoving => MoveDirection != Vector3.zero;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnDisable()
        {
            Vector3 bodyVelocity = _rigidbody.velocity;
            _rigidbody.velocity = new Vector3(0, bodyVelocity.y, 0);
        }

        private void Update()
        {

            Vector3 delta = moveDirection * moveSpeed * Time.deltaTime;
            _rigidbody.MovePosition(transform.position + delta);

        }
    }
}