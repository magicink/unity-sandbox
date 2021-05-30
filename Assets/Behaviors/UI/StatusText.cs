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
    }
}
