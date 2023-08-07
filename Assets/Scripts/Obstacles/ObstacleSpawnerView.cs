using UnityEngine;
using VContainer;

namespace Obstacles
{
    public sealed class ObstacleSpawnerView : MonoBehaviour
    {
        [SerializeField] private ObstacleView obstacle;
        [SerializeField, Tooltip("In seconds")]
        private float startDelay, spawnDelay;
        private ObstacleSpawner _obstacleSpawner;
        private bool _canSpawn;

        [Inject]
        private void Construct(ObstacleSpawner obstacleSpawner) => _obstacleSpawner = obstacleSpawner;

        public void StartSpawn()
        {
            InvokeRepeating(nameof(Spawn), startDelay, spawnDelay);
            _canSpawn = true;
        }

        private void Spawn()
        {
            if (_canSpawn) _obstacleSpawner.Spawn(obstacle);
        }

        public void StopSpawn()
        {
            StopAllCoroutines();
            _canSpawn = false;
        }
    }
}