namespace Spounka.Core
{
    public interface IGameInput
    {
        public float GetXAxis { get; }
        public float GetYAxis { get; }
        public bool Shoot { get; }
        public UnityEngine.Vector2 GetAxis();
    }
}