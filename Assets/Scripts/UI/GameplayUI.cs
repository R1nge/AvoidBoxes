using UnityEngine;

namespace UI
{
    public sealed class GameplayUI
    {
        private readonly GameObject _ui;
        
        public GameplayUI(GameObject ui) => _ui = ui;

        public void Show() => _ui.SetActive(true);

        public void Hide() => _ui.SetActive(false);
    }
}