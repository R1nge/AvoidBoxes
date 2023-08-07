using UnityEngine;

namespace Player
{
    public class MobilePlayerInput : PlayerInput
    {
        public override void GetInput()
        {
            if (Input.touchCount > 0)
            {
                var touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began) OnOnInputEvent();
            }
        }
    }
}