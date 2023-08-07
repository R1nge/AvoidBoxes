using Score;

namespace Obstacles
{
    public sealed class Obstacle
    {
        private readonly ScoreService _scoreService;
        
        public Obstacle(ScoreService scoreService) => _scoreService = scoreService;

        public void IncreaseScore(int amount) => _scoreService.IncreaseScore(amount);
    }
}