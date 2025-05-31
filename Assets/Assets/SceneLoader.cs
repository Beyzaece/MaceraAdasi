using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadmalzemeScene()
    {
        SceneManager.LoadScene("secimmalzeme");
    }

    public void LoadWorldScene()
    {
        SceneManager.LoadScene("DunyaKesif");
    }

    public void LoadARScene()
    {
        SceneManager.LoadScene("ar");
    }
    public void LoadavatarolusturmaScene()
    {
        SceneManager.LoadScene("avataroluþturma");

    }
    public void LoadYemekScene()
    {
        SceneManager.LoadScene("KültürelYemek");

    }

    public void LoadmAvatarOynatScene()
    {
        SceneManager.LoadScene("AvatarOynat");
    }

    public void Loadabigben()
    {
        SceneManager.LoadScene("arbigben");

    }
    public void LoadgirisScene()
    {
        SceneManager.LoadScene("Girissahnesi");

    }
}