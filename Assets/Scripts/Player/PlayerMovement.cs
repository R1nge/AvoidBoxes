using UnityEngine;

namespace Player
{
    public sealed class PlayerMovement
    {
        private readonly Rigidbody2D _rigidbody2D;
        private Vector2 _direction;
        private bool _enabled;
        private float _speed;

        public PlayerMovement(Rigidbody2D rigidbody2D)
        {
            _rigidbody2D = rigidbody2D;
        }

        public bool Enabled(bool newState) => _enabled = newState;

        public void SetSpeed(float speed) => _speed = speed;

        public Vector3 GetDirection() => _direction;

        public void SetDirection(Vector3 direction) => _direction = direction;

        public void Move()
        {
            if (_enabled) _rigidbody2D.AddForce(_direction * (_speed * Time.fixedDeltaTime));
        }
    }
}