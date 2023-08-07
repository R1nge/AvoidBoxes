using Obstacles;
using States;
using UnityEngine;
using VContainer;

namespace Player
{
    public class PlayerCollisionView : MonoBehaviour
    {
        private GameStateManager _gameStateManager;

        [Inject]
        private void Construct(GameStateManager gameStateManager) => _gameStateManager = gameStateManager;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent(out ObstacleView _))
            {
                _gameStateManager.ChangeState(GameStates.GameOver);
            }
        }
    }
}