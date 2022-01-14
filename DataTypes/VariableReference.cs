using System;

namespace Spounka.Core.DataTypes
{
    [Serializable]
    public class VariableReference<T>
    {
        public bool useConstant;
        public T constantValue;
        public Variable<T> variable;

        public VariableReference()
        {
        }

        public VariableReference(T value)
        {
            useConstant = true;
            constantValue = value;
        }

        public T Value
        {
            get => useConstant ? constantValue : variable.value;
            set
            {
                if (useConstant)
                    constantValue = value;
                else
                    variable.value = value;
            }
        }

        public static implicit operator T(VariableReference<T> val)
        {
            return val.Value;
        }
    }
}