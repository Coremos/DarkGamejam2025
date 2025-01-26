using UnityEngine;

namespace Watermelon
{
    public class FullScreen : MonoBehaviour
    {
        public void FullScreenButton()
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }
}