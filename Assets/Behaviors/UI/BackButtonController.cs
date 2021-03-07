using UnityEngine;
using UnityEngine.SceneManagement;

namespace Behaviors.UI
{
    public class BackButtonController : MonoBehaviour
    {
        private void Start()
        {
            SceneSelector.Instance.HandleSceneSelection += HandleSceneSelection;
            gameObject.SetActive(false);
        }

        private void HandleSceneSelection()
        {
            gameObject.SetActive(true);
        }

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
