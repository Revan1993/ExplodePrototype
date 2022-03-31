using Entitas;
using UnityEngine;

namespace EcsSources.Components.ObstComponents
{
    [Game]
    public class ExplodeComponent : IComponent
    {
        public float ExplosionForce;
        public Vector3 ExplosionPosition;
        public float ExplosionRadius;
        public float UpwardsModifier;
    }
}