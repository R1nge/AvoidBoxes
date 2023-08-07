using UnityEngine;

namespace UI
{
    public sealed class MainMenuUI
    {
        private readonly GameObject _ui;
        
        public MainMenuUI(GameObject ui) => _ui = ui;

        public void Show() => _ui.SetActive(true);

        public void Hide() => _ui.SetActive(false);
    }
}