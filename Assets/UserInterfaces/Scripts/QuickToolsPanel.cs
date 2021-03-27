using UnityEngine;
using UnityEngine.UIElements;

namespace UserInterfaces.Scripts
{
    public class QuickToolsPanel : MonoBehaviour
    {
        private void OnEnable()
        {
            var rootElement = GetComponent<UIDocument>().rootVisualElement;
            var myButton = new Button() { text = "My Button" };
            myButton.style.width = 160;
            myButton.style.height = 30;
            rootElement.Add(myButton);
        }
    }
}
