using HeroInGame.Moves;
using UnityEngine;

namespace Obsticales
{
    public class CollectObst : Obst
    {
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.GetComponent<HeroInputListener>())
            {
                gameObject.SetActive(false);
            }
        }
        
        private void FixedUpdate()
        {
            var scale = PlayerPrefs.GetInt("CollectObstSize", 2) / 10f;
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}