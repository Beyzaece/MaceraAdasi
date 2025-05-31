using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSceneLoader : MonoBehaviour
{
    public float delay = 10f; // Ka� saniye sonra ge�ilece�ini ayarlars�n
    public string sceneToLoad = "GorevSecimi"; // Ge�ilecek sahnenin ad�

    void Start()
    {
        Invoke("LoadNextScene", delay);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}