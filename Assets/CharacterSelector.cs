using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public void SelectCharacter(GameObject character)
    {
        CharacterHolder.Instance.SelectedCharacter = character;
        Debug.Log("Karakter se�ildi: " + character.name);
    }
}
