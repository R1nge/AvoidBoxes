using UnityEngine;

namespace Score
{
    public sealed class ScoreSaverService
    {
        private const string SCORE = "Score";
        private int _highScore;

        public int GetHighScore() => _highScore;

        public void LoadHighScore() => _highScore = PlayerPrefs.GetInt(SCORE);

        public void SaveScore(int score)
        {
            PlayerPrefs.SetInt(SCORE, score);
            PlayerPrefs.Save();
            
        }
    }
}