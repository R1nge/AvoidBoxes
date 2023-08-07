using TMPro;

namespace UI
{
    public sealed class ScoreUI
    {
        private readonly TextMeshProUGUI _score;
        private readonly TextMeshProUGUI _highScore;
        
        public ScoreUI(TextMeshProUGUI score, TextMeshProUGUI highScore)
        {
            _score = score;
            _highScore = highScore;
        }

        public void UpdateScore(int score) => _score.text = $"Score: {score}";

        public void UpdateHighScore(int highScore) => _highScore.text = $"HighScore: {highScore}";
    }
}