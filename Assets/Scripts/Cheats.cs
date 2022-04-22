using System.ComponentModel;
using UnityEngine;

namespace DefaultNamespace
{
    public class Cheats : MonoBehaviour
    {
        private class GameCheats
        {
            // [Category("Explosion")]
            // public int ExplosionPower
            // {
            //     get => PlayerPrefs.GetInt("ExplosionPower", 400);
            //     set => PlayerPrefs.SetInt("ExplosionPower", value);
            // }
            //
            // [Category("Size")]
            // public int ObstSize
            // {
            //     get =>PlayerPrefs.GetInt("ObstSize", 2);
            //     set => PlayerPrefs.SetInt("ObstSize", value);
            // }
            //
            // [Category("Size")]
            // public int CollectObstSize
            // {
            //     get =>PlayerPrefs.GetInt("CollectObstSize", 2);
            //     set => PlayerPrefs.SetInt("CollectObstSize", value);
            // }
            //
            // [Category("Size")]
            // public int HeroSize
            // {
            //     get => PlayerPrefs.GetInt("HeroSize", 5);
            //     set => PlayerPrefs.SetInt("HeroSize", value );
            // }
        }
        
        private static Cheats Instance { get; set; }
        private GameCheats gameCheats { get; set; }

        void Awake()
        {
            if (Instance != null)
            {
                Destroy(this);
                return;
            }

            Instance = this;

            InitDebugMenu();
        }


        void InitDebugMenu()
        {
            if (gameCheats == null)
            {
                gameCheats = new GameCheats();
            }
            
            SRDebug.Instance?.AddOptionContainer(gameCheats);
        }
    }
}