using Entitas;
using UnityEngine.EventSystems;

namespace EcsSources.Components
{
    [Input]
    public class TouchWorldPositionComponent : IComponent
    {
        public bool IsTouchActive;
        public PointerEventData TouchData;
    }
}