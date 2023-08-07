using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    public sealed class GameOverUIView : MonoBehaviour
    {
        [SerializeField] private GameObject ui;
        [SerializeField] private Button restartButton;
        private GameOverUI _gameOverUI;

        private void Awake()
        {
            _gameOverUI = new GameOverUI(ui);
            restartButton.onClick.AddListener(() => { SceneManager.LoadSceneAsync(0); });
        }

        public void Show() => _gameOverUI.Show();

        public void Hide() => _gameOverUI.Hide();

        private void OnDestroy() => restartButton.onClick.RemoveAllListeners();
    }
}