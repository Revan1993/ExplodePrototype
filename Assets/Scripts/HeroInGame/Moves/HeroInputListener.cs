using Input.InputListeners;
using SceneInstallers;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;

namespace HeroInGame.Moves
{
    public class HeroInputListener : InputListener
    {
        private void Start()
        {
            var controller = GameSceneInstaller.Context.Container.Resolve<IInputListenersController>();      
            
            controller.OnDrag.Subscribe(Drag);
            controller.OnTouch.Subscribe(result =>
            {
                InputStateChanged(result.Item1, result.Item2);
            });
        }

        public override void InputStateChanged(bool isTouch, PointerEventData touchData = null)
        {
            if(touchData != null)
            {
                var pos = Camera.main.ScreenToWorldPoint(touchData.position);
                transform.position = new Vector3(pos.x, pos.y, transform.position.z);
            }
        }

        public override void Drag(PointerEventData dragData)
        {
            if(dragData != null)
            {
                var pos = Camera.main.ScreenToWorldPoint(dragData.position);
                transform.position = new Vector3(pos.x, pos.y, transform.position.z);
            }
        }
        
        private void FixedUpdate()
        {
            var scale = PlayerPrefs.GetInt("HeroSize", 5) / 10f;
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}