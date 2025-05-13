using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAutoLoader : MonoBehaviour
{
    public string sceneName = "LupenMenue";  // Meine Zielszene
    public float delay = 20f;                // Zeit bis Wechsel

    void Start()
    {
        Invoke("LoadNextScene", delay);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
