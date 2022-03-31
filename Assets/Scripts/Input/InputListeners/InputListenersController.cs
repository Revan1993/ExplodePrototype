using System;
using UniRx;
using UnityEngine.EventSystems;

namespace Input.InputListeners
{
    public interface IInputListenersController
    {
        IObservable<(bool, PointerEventData)> OnTouch { get; }
        IObservable<PointerEventData> OnDrag { get; }
    }
    
    public interface IInputListenersControllerWritable
    {
        void Touch(bool isTouch, PointerEventData touchData = null);
        void Drag(PointerEventData dragData);
    }
    
    //Initializing when binding to context
    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class InputListenersController : IInputListenersController, IInputListenersControllerWritable
    {
        private Subject<(bool, PointerEventData)> touchTriggers = new Subject<(bool, PointerEventData)>();
        private Subject<PointerEventData> dragTriggers = new Subject<PointerEventData>();

        public IObservable<(bool, PointerEventData)> OnTouch => touchTriggers;
        public IObservable<PointerEventData> OnDrag => dragTriggers;

        public void Touch(bool isTouch, PointerEventData touchData = null)
        {
            touchTriggers.OnNext((isTouch, touchData));
        }

        public void Drag(PointerEventData dragData)
        {
            dragTriggers.OnNext(dragData);
        }
    }
}