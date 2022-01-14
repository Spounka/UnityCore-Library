using UnityEngine;

namespace Spounka.Core.DataTypes
{
    public class Variable<T> : ScriptableObject
    {
        public T value;
    }
}