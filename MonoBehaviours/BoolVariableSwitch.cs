using Spounka.Core.DataTypes;
using UnityEngine;

namespace Spounka.core
{
    public class BoolVariableSwitch : MonoBehaviour
    {
        [SerializeField] private VariableReference<bool> variable;

        public void SetVariable(bool value)
        {
            variable.Value = value;
        }
    }
}