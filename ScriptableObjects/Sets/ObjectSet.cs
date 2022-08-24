using System.Collections.Generic;
using UnityEngine;

namespace Spounka.Core
{
    [CreateAssetMenu(fileName = "ObjectSet", menuName = "Sets/ObjectSet")]
    public class ObjectSet : ScriptableObject
    {
        public readonly LinkedList<GameObject> Set = new LinkedList<GameObject>();

        public void AddElement(GameObject obj)
        {
            if (!Set.Contains(obj))
                Set.AddLast(obj);
        }

        public void RemoveElement(GameObject obj)
        {
            if (Set.Contains(obj))
                Set.Remove(obj);
        }
    }
}