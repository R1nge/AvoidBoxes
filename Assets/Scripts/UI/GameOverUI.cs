using UnityEngine;

namespace UI
{
    public class GameOverUI
    {
        private readonly GameObject _ui;

        public GameOverUI(GameObject ui) => _ui = ui;

        public void Show() => _ui.SetActive(true);

        public void Hide() => _ui.SetActive(false);
    }
}