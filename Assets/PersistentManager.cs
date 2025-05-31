using UnityEngine;

public class PersistentManager : MonoBehaviour
{
    public static PersistentManager Instance;

    public GameObject selectedCharacter;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Sahne ge�i�inde yok olmas�n
        }
        else
        {
            Destroy(gameObject); // Zaten varsa yok et
        }
    }
}