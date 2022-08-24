using UnityEngine;

namespace Spounka.Core
{
    public class AddToSet : MonoBehaviour
    {
        [SerializeField] private ObjectSet fishes;


        private void OnEnable()
        {
            if (fishes != null)
                fishes.AddElement(gameObject);
        }

        private void OnDisable()
        {
            if (fishes != null)
                fishes.RemoveElement(gameObject);
        }
    }
}