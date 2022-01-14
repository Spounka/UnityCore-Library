using UnityEngine;

namespace Spounka.Core.Input
{
    public class MobileGameInput : IGameInput
    {
        public float GetXAxis => touchPosition.x;

        public float GetYAxis => touchPosition.y;

        public bool Shoot => currentTouch.phase == TouchPhase.Ended;

        public Vector2 GetAxis() => new Vector2(GetXAxis, GetYAxis);


        private Touch currentTouch
        {
            get
            {
                if (UnityEngine.Input.touchCount <= 0) return new Touch();
                return UnityEngine.Input.GetTouch(0);
            }
        }

        private static Vector2 touchPosition
        {
            get
            {
                if (UnityEngine.Input.touchCount <= 0) return Vector2.zero;
                var touch = UnityEngine.Input.GetTouch(0);

                if (Camera.main == null)
                {
                    Debug.LogError("No Camera found!");
                    return Vector2.zero;
                }

                var position = Camera.main.ScreenToWorldPoint(touch.position);
                return position;
            }
        }
    }
}