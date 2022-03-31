using EcsSources.ECSSystems.InputSystems;

namespace EcsSources.ECSSystems
{
    public sealed class RootInputSystems : Feature
    {
        public RootInputSystems()
        {
            Add(new ReactiveDragSystem());
            Add(new ReactiveTouchSystem());
        }
    }
}