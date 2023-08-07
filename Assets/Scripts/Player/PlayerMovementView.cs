using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class PlayerMovementView : MonoBehaviour
    {
        [SerializeField] private float speed;
        private PlayerInput _playerInput;
        private PlayerMovement _playerMovement;
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();

            _playerMovement = new PlayerMovement(_rigidbody2D);
            _playerMovement.SetSpeed(speed);
            _playerMovement.SetDirection(Vector3.right);

#if (UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR
        _playerInput = new MobilePlayerInput();
#else
            _playerInput = new DesktopPlayerInput();
#endif

            _playerInput.OnInput += ChangeMovementDirection;
        }

        private void ChangeMovementDirection() => _playerMovement.SetDirection(-_playerMovement.GetDirection());

        private void Update() => _playerInput.GetInput();

        private void FixedUpdate() => _playerMovement.Move();

        private void OnCollisionEnter2D(Collision2D other)
        {
            _playerInput.Enabled(true);
            _playerMovement.Enabled(true);
        }

        private void OnDestroy() => _playerInput.OnInput -= ChangeMovementDirection;
    }
}