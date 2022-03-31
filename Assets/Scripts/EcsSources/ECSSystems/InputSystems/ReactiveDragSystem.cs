using System.Collections.Generic;
using Entitas;
using Input.InputListeners;
using SceneInstallers;
using Zenject;

namespace EcsSources.ECSSystems.InputSystems
{
    public class ReactiveDragSystem : ReactiveSystem<InputEntity>
    {
        [Inject] private IInputListenersControllerWritable inputListenersControllerWritable;
        
        public ReactiveDragSystem() : base(Contexts.sharedInstance.input)
        {
            GameSceneInstaller.Context.Container.Inject(this);
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context) =>
            context.CreateCollector(InputMatcher.DragWorldPosition);

        protected override bool Filter(InputEntity entity) => entity.hasDragWorldPosition;

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (var worldEntity in entities)
            {
                inputListenersControllerWritable.Drag(worldEntity.dragWorldPosition.DragData);
            }
        }
    }
}