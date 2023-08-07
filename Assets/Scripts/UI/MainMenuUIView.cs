using States;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace UI
{
    public sealed class MainMenuUIView : MonoBehaviour
    {
        [SerializeField] private GameObject ui;
        [SerializeField] private Button playButton;
        private MainMenuUI _mainMenuUI;
        private GameStateManager _gameStateManager;

        [Inject]
        private void Construct(GameStateManager gameStateManager) => _gameStateManager = gameStateManager;

        private void Awake()
        {
            _mainMenuUI = new MainMenuUI(ui);
            playButton.onClick.AddListener(() => { _gameStateManager.ChangeState(GameStates.Gameplay); });
        }

        public void Show() => _mainMenuUI.Show();

        public void Hide() => _mainMenuUI.Hide();

        private void OnDestroy() => playButton.onClick.RemoveAllListeners();
    }
}