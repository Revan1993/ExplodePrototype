using UnityEngine;

namespace Buttons
{
    public class StartButton : MonoBehaviour
    {
        public void ClickStart()
        {
            var entities = Contexts.sharedInstance.game.GetGroup(GameMatcher.Id);

            foreach (var gameEntity in entities)
            {
                gameEntity.ReplaceExplode(PlayerPrefs.GetInt("ExplosionPower", 400),
                    new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f),
                    Random.Range(5f, 7f), 0);
            }
        }
    }
}