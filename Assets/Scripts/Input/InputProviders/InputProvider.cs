using UnityEngine;
using UnityEngine.EventSystems;

namespace Input.InputProviders
{
    public class InputProvider : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
    {
        private InputEntity inputEntity;

        private void Awake()
        {
            inputEntity = Contexts.sharedInstance.input.CreateEntity();
            Time.timeScale = 0.15f;
        }
        
        public void OnPointerDown(PointerEventData eventData)
        {
            inputEntity.ReplaceTouchWorldPosition(true, eventData);
            Time.timeScale = 1;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            inputEntity.ReplaceTouchWorldPosition(false, null);
            if(inputEntity.hasDragWorldPosition)
                inputEntity.RemoveDragWorldPosition();
            Time.timeScale = 0.15f;
        }

        public void OnDrag(PointerEventData eventData)
        {
            inputEntity.ReplaceDragWorldPosition(eventData);
        }
    }
}