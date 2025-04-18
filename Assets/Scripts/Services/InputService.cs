using UnityEngine;

namespace Services
{
    public class InputService : MonoBehaviour
    {
        public bool IsJumped()
        {
            return Input.GetKeyDown("Space");
        }

        public bool IsAttacked()
        {
            return Input.GetMouseButtonDown(0);
        }

        public bool IsReloaded()
        {
            return Input.GetKeyDown("R");
        }

        public Vector3 CheckMove()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            return new Vector3(horizontal, 0, vertical);
        }
    }
}