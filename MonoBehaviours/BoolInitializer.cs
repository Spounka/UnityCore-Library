using Spounka.Core.DataTypes;
using UnityEngine;

namespace Spounka.core
{
    public class BoolInitializer : MonoBehaviour
    {
        [SerializeField] private bool initialValue;
        [SerializeField] private VariableReference<bool> variable;

        private void Awake()
        {
            variable.Value = initialValue;
        }
    }
}