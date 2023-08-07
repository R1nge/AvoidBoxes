using System;
using Obstacles;
using UI;
using UnityEngine;

namespace States
{
    public sealed class GameStateFactory : MonoBehaviour
    {
        [SerializeField] private MainMenuUIView mainMenuUIView;
        [SerializeField] private GameplayUIView gameplayUIView;
        [SerializeField] private GameOverUIView gameOverUIView;
        [SerializeField] private ObstacleSpawnerView obstacleSpawnerView;
        [SerializeField] private PlayerSpawnerView playerSpawnerView;
        
        public IGameState GetState(GameStates state)
        {
            switch (state)
            {
                case GameStates.MainMenu:
                    return new MainMenuState(mainMenuUIView);
                case GameStates.Gameplay:
                    return new GameplayState(gameplayUIView, obstacleSpawnerView, playerSpawnerView);
                case GameStates.GameOver:
                    return new GameOverState(gameOverUIView);
                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }
    }
}