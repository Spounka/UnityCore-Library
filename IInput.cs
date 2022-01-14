namespace Spounka.Core
{
    public interface IInput
    {
        public float GetXAxis { get; }
        public float GetYAxis { get; }
        public bool Shoot { get; }
        public UnityEngine.Vector2 GetAxis();
    }
}