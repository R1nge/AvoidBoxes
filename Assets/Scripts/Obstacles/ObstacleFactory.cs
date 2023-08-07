using Score;
using VContainer;

namespace Obstacles
{
    public sealed class ObstacleFactory
    {
        private readonly ScoreService _scoreService;

        [Inject]
        public ObstacleFactory(ScoreService scoreService) => _scoreService = scoreService;

        public Obstacle Spawn() => new(_scoreService);
    }
}