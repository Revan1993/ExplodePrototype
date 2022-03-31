using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace CameraScripts
{
    public class HitImageFlick : MonoBehaviour
    {
        private static HitImageFlick instance;

        [SerializeField] private Image image;

        private void Start()
        {
            instance = this;
        }

        public static async void Flick()
        {
            instance.image.color = new Color(instance.image.color.r, instance.image.color.g, instance.image.color.b, 1);
            await UniTask.DelayFrame(5);
            instance.image.color = new Color(instance.image.color.r, instance.image.color.g, instance.image.color.b, 0);
            await UniTask.DelayFrame(5);
            instance.image.color = new Color(instance.image.color.r, instance.image.color.g, instance.image.color.b, 1);
            await UniTask.DelayFrame(5);
            instance.image.color = new Color(instance.image.color.r, instance.image.color.g, instance.image.color.b, 0);
        }
    }
}