using Proyecto26;
using UnityEngine;

namespace Behaviors.System
{
    public class RestClientController : MonoBehaviour
    {
        public static RestClientController Instance;

        public delegate void OnGetSuccess();

        public OnGetSuccess HandleGetSuccess;

        private void Awake()
        {
            if (Instance == null) Instance = this;
        }

        public void GetAsync()
        {
            RestClient.Get("http://localhost:7298/users").Then(response =>
            {
                if (response.StatusCode == 200)
                {
                    HandleGetSuccess?.Invoke();
                }
            });
        }
    }
}
