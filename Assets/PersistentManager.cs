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
            DontDestroyOnLoad(gameObject); // Sahne geçiþinde yok olmasýn
        }
        else
        {
            Destroy(gameObject); // Zaten varsa yok et
        }
    }
}