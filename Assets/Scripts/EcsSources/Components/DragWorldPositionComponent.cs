using Entitas;
using UnityEngine.EventSystems;

namespace EcsSources.Components
{
    [Input]
    public class DragWorldPositionComponent : IComponent
    {
        public PointerEventData DragData;
    }
}