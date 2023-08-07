using UnityEngine;
using VContainer;

namespace Obstacles
{
    public sealed class ObstacleView : MonoBehaviour
    {
        [SerializeField] private int points;
        private ObstacleFactory _obstacleFactory;
        private Obstacle _obstacle;

        [Inject]
        private void Construct(ObstacleFactory obstacleFactory) => _obstacleFactory = obstacleFactory;

        private void Start() => _obstacle = _obstacleFactory.Spawn();

        private void OnCollisionEnter2D(Collision2D other)
        {
            _obstacle.IncreaseScore(points);
            Destroy(gameObject);
        }
    }
}