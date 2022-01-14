using System;
using UnityEngine;

namespace Spounka.Core.DataTypes
{
    [Serializable]
    public class Vector2Reference
    {
        public VariableReference<float> x, y;

        public static implicit operator Vector2(Vector2Reference other)
        {
            return new Vector2(other.x, other.y);
        }
    }
}