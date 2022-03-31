using System.Collections.Generic;
using Entitas;
using Obsticales;
using SceneInstallers;

namespace EcsSources.ECSSystems.ObstSystems
{
    public interface IExplosionSystem
    {
        void RegisterObst(Obst obst);
    }
    
    public class ExplosionSystem : ReactiveSystem<GameEntity>, IExplosionSystem
    {
        public Dictionary<int, Obst> listeners = new Dictionary<int, Obst>();
        
        public ExplosionSystem() : base(Contexts.sharedInstance.game)
        {
            GameSceneInstaller.Context.Container.Bind<IExplosionSystem>().FromInstance(this).AsSingle();
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.Explode);

        protected override bool Filter(GameEntity entity) => entity.hasExplode;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var gameEntity in entities)
            {
                listeners[gameEntity.id.Id].AddForce(gameEntity.explode);
                // gameEntity.ReplaceExplode(Random.Range(300, 700),
                //     new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f), 
                //     Random.Range(5f, 15f), 0);
            }
        }

        public void RegisterObst(Obst obst)
        {
            listeners.Add(obst.Id, obst);
        }
    }
}