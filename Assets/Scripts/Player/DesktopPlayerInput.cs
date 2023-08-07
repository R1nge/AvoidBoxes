using UnityEngine;

namespace Player
{
    public class DesktopPlayerInput : PlayerInput
    {
        public override void GetInput()
        {
            if (Input.GetMouseButtonDown(0)) OnOnInputEvent();
        }
    }
}