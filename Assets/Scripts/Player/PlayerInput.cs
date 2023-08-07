using System;

namespace Player
{
    public abstract class PlayerInput
    {
        private bool _enabled;
        public event Action OnInput;

        public bool Enabled(bool newState) => _enabled = newState;

        public abstract void GetInput();

        protected void OnOnInputEvent()
        {
            if (_enabled) OnInput?.Invoke();
        }
    }
}