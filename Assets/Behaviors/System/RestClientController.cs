using UnityEngine;

namespace Behaviors.System
{
    public class RestClientController : MonoBehaviour
    {
        public static RestClientController Instance;

        private void Awake()
        {
            if (Instance == null) Instance = this;
        }
    }
}
