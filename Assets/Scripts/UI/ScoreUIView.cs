using Score;
using TMPro;
using UnityEngine;
using VContainer;

namespace UI
{
    public sealed class ScoreUIView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI score, highScore;
        private ScoreSaverService _scoreSaverService;
        private ScoreService _scoreService;
        private ScoreUI _scoreUI;
        
        [Inject]
        private void Construct(ScoreSaverService scoreSaverService, ScoreService scoreService)
        {
            _scoreSaverService = scoreSaverService;
            _scoreService = scoreService;
        }

        private void Start()
        {
            _scoreUI = new ScoreUI(score, highScore);
            _scoreService.OnScoreIncreased += OnScoreIncreased;
            _scoreService.OnNewHighScore += OnNewHighScore;
            
            OnScoreIncreased(0);
            OnNewHighScore(_scoreSaverService.GetHighScore());
        }

        private void OnScoreIncreased(int newScore)
        {
            _scoreUI.UpdateScore(newScore);
        }

        private void OnNewHighScore(int newHighScore)
        {
            _scoreUI.UpdateHighScore(newHighScore);
        }

        private void OnDestroy()
        {
            _scoreService.OnScoreIncreased -= OnScoreIncreased;
            _scoreService.OnNewHighScore -= OnNewHighScore;
        }
    }
}