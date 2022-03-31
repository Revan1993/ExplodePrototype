using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace EcsSources.Components.ObstComponents
{
    [Game]
    public class IdComponent : IComponent
    {
        [PrimaryEntityIndex]
        public int Id;
    }
}