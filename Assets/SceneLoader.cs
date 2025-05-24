using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadAvatarScene()
    {
        SceneManager.LoadScene("AvatarOynat");
    }

    public void LoadWorldScene()
    {
        SceneManager.LoadScene("DunyaKesif");
    }
}