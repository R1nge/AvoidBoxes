using UI;

namespace States
{
    public sealed class MainMenuState : IGameState
    {
        private readonly MainMenuUIView _mainMenuUIView;

        public MainMenuState(MainMenuUIView mainMenuUIView) => _mainMenuUIView = mainMenuUIView;

        public void Enter() => _mainMenuUIView.Show();

        public void Exit() => _mainMenuUIView.Hide();
    }
}