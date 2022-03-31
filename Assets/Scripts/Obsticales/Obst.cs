using System;
using CameraScripts;
using EcsSources.Components.ObstComponents;
using EcsSources.ECSSystems.ObstSystems;
using HeroInGame.Moves;
using SceneInstallers;
using UnityEngine;
using Zenject;

namespace Obsticales
{
    public class Obst : MonoBehaviour
    {
        [Inject] private IExplosionSystem explosionSystem;

        [HideInInspector] public int Id;

        private void Start()
        {
            GameSceneInstaller.Context.Container.Inject(this);
            var entity = Contexts.sharedInstance.game.CreateEntity();
            Id = ++IdProvider.Id;
            entity.ReplaceId(Id);
            explosionSystem.RegisterObst(this);
        }

        public void AddForce(ExplodeComponent explodeComponent)
        {
            gameObject.SetActive(true);
            GetComponent<Rigidbody>().AddExplosionForce(explodeComponent.ExplosionForce,
                explodeComponent.ExplosionPosition, explodeComponent.ExplosionRadius, explodeComponent.UpwardsModifier);
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.GetComponent<HeroInputListener>())
            {
                HitImageFlick.Flick();
                Handheld.Vibrate();
            }
        }

        private void FixedUpdate()
        {
            var scale = PlayerPrefs.GetInt("ObstSize", 2) / 10f;
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}