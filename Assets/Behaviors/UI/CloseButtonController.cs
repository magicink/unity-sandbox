using UnityEngine;

namespace Behaviors.UI
{
    public class CloseButtonController : MonoBehaviour
    {
        public void CloseApplication()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif !UNITY_EDITOR
            Application.Quit();
#endif
        }
    }
}