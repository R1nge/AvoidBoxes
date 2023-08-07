using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Obstacles
{
    public sealed class ObstacleSpawner
    {
        private readonly IObjectResolver _objectResolver;

        [Inject]
        public ObstacleSpawner(IObjectResolver objectResolver) => _objectResolver = objectResolver;

        public void Spawn(ObstacleView obstacle) => _objectResolver.Instantiate(obstacle, GetPosition(), Quaternion.identity);

        private Vector3 GetPosition() => new(Random.Range(-2.35f, 2.35f), Random.Range(6.5f, 7.5f), 0);
    }
}