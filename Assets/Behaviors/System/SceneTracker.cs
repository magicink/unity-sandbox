using Behaviors.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTracker : MonoBehaviour
{
    public static SceneTracker Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        if (SceneSelector.Instance == null)
        {
            SceneManager.LoadScene("Scene Selector");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
