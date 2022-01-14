using UnityEngine;

namespace Spounka.Core.Input
{
    public class KeyboardGameInput : IGameInput
    {
        public float GetXAxis => UnityEngine.Input.GetAxisRaw("Horizontal");

        public float GetYAxis => UnityEngine.Input.GetAxisRaw("Vertical");

        public bool Shoot => UnityEngine.Input.GetKeyDown(KeyCode.Space);

        public Vector2 GetAxis() => new Vector2(GetXAxis, GetYAxis);
    }
}