using UnityEngine;
using UnityEngine.SceneManagement;

namespace Behaviors.UI
{
    public class SceneSelector : MonoBehaviour
    {
        public static SceneSelector Instance;

        public delegate void OnSceneSelection();

        public OnSceneSelection HandleSceneSelection;

        private void Awake()
        {
            if (Instance == null) Instance = this;
        }

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
            gameObject.SetActive(false);
            HandleSceneSelection?.Invoke();
        }
    }
}
