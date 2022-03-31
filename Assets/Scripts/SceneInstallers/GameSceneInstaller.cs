using Cysharp.Threading.Tasks;
using EcsSources.ECSSystems;
using Input.InputListeners;
using UnityEngine;
using Zenject;

namespace SceneInstallers
{
    public class GameSceneInstaller : MonoInstaller
    {
        public static Context Context;

        [SerializeField] private Context context;

        private RootInputSystems inputSystems;
        private RootObstSystems obstSystem;

        public override void InstallBindings()
        {
            Context = context;

            context.Container.BindInterfacesTo<InputListenersController>().AsSingle();
            
            inputSystems = new RootInputSystems();
            inputSystems.Initialize();
            
            obstSystem = new RootObstSystems();
            obstSystem.Initialize();
            
            UniTask.Action(async () =>
            {
                while (true)
                {
                    inputSystems.Execute();
                    obstSystem.Execute();
                    await UniTask.DelayFrame(1);
                }
            }).Invoke();
        }

        private void OnDestroy()
        {
            // inputSystems.DeactivateReactiveSystems();
            // Contexts.sharedInstance.input.DestroyAllEntities();                
            // Contexts.sharedInstance.game.DestroyAllEntities();                
        }
    }
}