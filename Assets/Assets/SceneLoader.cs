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
        SceneManager.LoadScene("avatarolu�turma");

    }
    public void LoadYemekScene()
    {
        SceneManager.LoadScene("K�lt�relYemek");

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