using UI;

namespace States
{
    public sealed class GameOverState : IGameState
    {
        private readonly GameOverUIView _gameOverUIView;

        public GameOverState(GameOverUIView gameOverUIView) => _gameOverUIView = gameOverUIView;

        public void Enter() => _gameOverUIView.Show();

        public void Exit() => _gameOverUIView.Hide();
    }
}