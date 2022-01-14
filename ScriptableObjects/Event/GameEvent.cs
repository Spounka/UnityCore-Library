using System.Collections.Generic;
using UnityEngine;

namespace Spounka.Core.Event
{
    [CreateAssetMenu(fileName = "Event", menuName = "Event")]
    public class GameEvent : ScriptableObject
    {
        private readonly LinkedList<GameEventListener> listeners = new LinkedList<GameEventListener>();

        public void RegisterEvent(GameEventListener listener)
        {
            if (!listeners.Contains(listener))
                listeners.AddLast(listener);
        }

        public void UnregisterEvent(GameEventListener listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }

        public void Raise()
        {
            var current = listeners.First;
            while (current != null)
            {
                var next = current.Next;
                current.Value.Raise();
                current = next;
            }
        }
    }
}