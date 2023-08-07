using UnityEngine;

namespace UI
{
    public sealed class GameplayUIView : MonoBehaviour
    {
        [SerializeField] private GameObject ui;
        private GameplayUI _gameplayUI;

        private void Awake() => _gameplayUI = new GameplayUI(ui);

        public void Show() => _gameplayUI.Show();

        public void Hide() => _gameplayUI.Hide();
    }
}