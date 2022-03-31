using System.Collections.Generic;
using Entitas;
using Input.InputListeners;
using SceneInstallers;
using Zenject;

namespace EcsSources.ECSSystems.InputSystems
{
    public class ReactiveTouchSystem : ReactiveSystem<InputEntity>
    {
        [Inject] private IInputListenersControllerWritable inputListenersControllerWritable;

        public ReactiveTouchSystem() : base(Contexts.sharedInstance.input)
        {
            GameSceneInstaller.Context.Container.Inject(this);
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context) =>
            context.CreateCollector(InputMatcher.TouchWorldPosition);

        protected override bool Filter(InputEntity entity) => entity.hasTouchWorldPosition;

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (var touchEntity in entities)
            {
                inputListenersControllerWritable.Touch(touchEntity.touchWorldPosition.IsTouchActive,
                    touchEntity.touchWorldPosition.TouchData);
            }
        }
    }
}