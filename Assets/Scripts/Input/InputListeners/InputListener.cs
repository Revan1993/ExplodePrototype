using UnityEngine;
using UnityEngine.EventSystems;

namespace Input.InputListeners
{
    public abstract class InputListener : MonoBehaviour
    {
        public abstract void InputStateChanged(bool isTouch, PointerEventData touchData = null);
        public abstract void Drag(PointerEventData dragData);
    }
}