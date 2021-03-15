using Behaviors.System;
using TMPro;
using UnityEngine;

namespace Behaviors.UI
{
    public class StatusText : MonoBehaviour
    {
        private TextMeshProUGUI _text;

        private void Awake()
        {
            _text = GetComponent<TextMeshProUGUI>();
        }

        // Start is called before the first frame update
        private void Start()
        {
            RestClientController.Instance.HandleGetSuccess += HandleGetSuccess;
        }

        private void HandleGetSuccess()
        {
            if (_text) _text.text = "success!";
        }
    }
}
