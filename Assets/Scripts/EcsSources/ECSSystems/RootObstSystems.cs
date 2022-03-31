using EcsSources.ECSSystems.ObstSystems;

namespace EcsSources.ECSSystems
{
    public sealed class RootObstSystems : Feature
    {
        public RootObstSystems()
        {
            Add(new ExplosionSystem());
        }
    }
}