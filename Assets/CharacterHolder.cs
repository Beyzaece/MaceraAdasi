using UnityEngine;

public class CharacterHolder : MonoBehaviour
{
    public static CharacterHolder Instance;
    public GameObject SelectedCharacter;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetCharacter(GameObject character)
    {
        SelectedCharacter = character;
        Debug.Log("Seçilen karakter: " + character.name);
    }
}