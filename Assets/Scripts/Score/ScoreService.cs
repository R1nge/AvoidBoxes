using System;
using UnityEngine;
using VContainer;

namespace Score
{
    public sealed class ScoreService
    {
        public event Action<int> OnScoreIncreased, OnNewHighScore;
        private int _currentScore;
        private readonly ScoreSaverService _scoreSaverService;

        [Inject]
        public ScoreService(ScoreSaverService scoreSaverService)
        {
            _scoreSaverService = scoreSaverService;
        }

        public void IncreaseScore(int amount)
        {
            if (amount <= 0)
            {
                Debug.LogError($"ScoreService: Trying to add {amount}");
                return;
            }

            _currentScore += amount;
            OnScoreIncreased?.Invoke(_currentScore);

            if (_currentScore > _scoreSaverService.GetHighScore())
            {
                OnNewHighScore?.Invoke(_currentScore);
                _scoreSaverService.SaveScore(_currentScore);
            }
        }
    }
}