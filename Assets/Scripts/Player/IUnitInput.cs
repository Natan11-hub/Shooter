using UnityEngine;

namespace Unit
{
    public interface IUnitInput
    {
        public Vector3 MoveDirection { get; }
        public bool IsAttacked { get; }
        public bool IsJumped { get; }
    }
}