using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSceneLoader : MonoBehaviour
{
    public float delay = 10f; // Kaç saniye sonra geçileceðini ayarlarsýn
    public string sceneToLoad = "GorevSecimi"; // Geçilecek sahnenin adý

    void Start()
    {
        Invoke("LoadNextScene", delay);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}