using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public void SelectCharacter(GameObject character)
    {
        CharacterHolder.Instance.SelectedCharacter = character;
        SecimVerisi.SecilenAvatarAdi = character.name;
        Debug.Log("Karakter seçildi: " + character.name);
    }
}
