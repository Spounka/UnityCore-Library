using Spounka.Core.Sets;
using UnityEngine;

namespace Spounka.core
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