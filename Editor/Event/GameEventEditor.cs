using Spounka.Core.Event;
using UnityEditor;
using UnityEngine;

namespace Spounka.Core.Editor
{
    [CustomEditor(typeof(GameEvent))]
    public class GameEventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUI.enabled = Application.isPlaying;
            var e = target as GameEvent;
            // ReSharper disable once InvertIf
            if (GUILayout.Button("Raise"))
                if (e != null)
                    e.Raise();
        }
    }
}