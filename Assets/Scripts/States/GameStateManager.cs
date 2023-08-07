using System;
using System.Collections.Generic;
using VContainer;

namespace States
{
    public sealed class GameStateManager
    {
        public event Action<GameStates> OnStateChanged; 

        private Dictionary<GameStates, IGameState> _states;
        private IGameState _currentState;
        private readonly GameStateFactory _gameStateFactory;

        [Inject]
        private GameStateManager(GameStateFactory gameStateFactory)
        {
            _gameStateFactory = gameStateFactory;
        }
        
        public void Init()
        {
            var mainMenuState = _gameStateFactory.GetState(GameStates.MainMenu);
            var gameState = _gameStateFactory.GetState(GameStates.Gameplay);
            var gameOverState = _gameStateFactory.GetState(GameStates.GameOver);

            _states = new Dictionary<GameStates, IGameState>
            {
                { GameStates.MainMenu, mainMenuState },
                { GameStates.Gameplay, gameState },
                { GameStates.GameOver, gameOverState }
            };
        }

        public void ChangeState(GameStates newState)
        {
            _currentState?.Exit();
            _currentState = _states[newState];
            _currentState.Enter();
            OnStateChanged?.Invoke(newState);
        }
    }

    public enum GameStates
    {
        MainMenu,
        Gameplay,
        GameOver
    }
}