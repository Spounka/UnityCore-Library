using Spounka.Core.DataTypes;
using Spounka.Core.Event;
using UnityEngine;

namespace Spounka.Core
{
    [CreateAssetMenu(fileName = "Timer", menuName = "Systems/Timer")]
    public class TimerSO : ScriptableObject
    {
        public VariableReference<float> remainingTime;
        public VariableReference<float> maxTime;
        public GameEvent onTimerOff;

        private bool _ended;

        public void ResetCounter()
        {
            remainingTime.Value = maxTime.Value;
            _ended = false;
        }

        public void DecrementTimer(float value)
        {
            if (remainingTime.Value > 0)
            {
                remainingTime.Value -= value;
                if (remainingTime < 0)
                    remainingTime.Value = 0;
            }

            else if (!_ended)
            {
                remainingTime.Value = 0;
                onTimerOff.Raise();
                _ended = true;
            }
        }
    }
}