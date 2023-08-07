using Obstacles;
using UI;

namespace States
{
    public sealed class GameplayState : IGameState
    {
        private readonly GameplayUIView _gameplayUIView;
        private readonly ObstacleSpawnerView _obstacleSpawnerView;
        private readonly PlayerSpawnerView _playerSpawnerView;
        
        public GameplayState(
            GameplayUIView gameplayUIView, 
            ObstacleSpawnerView obstacleSpawnerView, 
            PlayerSpawnerView playerSpawnerView)
        {
            _gameplayUIView = gameplayUIView;
            _obstacleSpawnerView = obstacleSpawnerView;
            _playerSpawnerView = playerSpawnerView;
        }
        
        public void Enter()
        {
            _playerSpawnerView.Spawn();
            _gameplayUIView.Show();
            _obstacleSpawnerView.StartSpawn();
        }

        public void Exit()
        {
            _playerSpawnerView.Destroy();
            _gameplayUIView.Hide();
            _obstacleSpawnerView.StopSpawn();
        }
    }
}