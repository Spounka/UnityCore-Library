using UnityEngine;

namespace Spounka.Core.Input
{
    public class MouseInput : IInput
    {
        public float GetXAxis
        {
            get
            {
                if (Camera.main != null) return Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x;
                Debug.LogError("No Camera found!");
                return 0;
            }
        }

        public float GetYAxis
        {
            get
            {
                if (Camera.main != null) return Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).y;
                Debug.LogError("No Camera found!");
                return 0;
            }
        }

        public bool Shoot => UnityEngine.Input.GetMouseButton(0);

        public Vector2 GetAxis() => new Vector2(GetXAxis, GetYAxis);
    }
}