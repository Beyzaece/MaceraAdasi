using UnityEngine;
using TMPro;

public class CharacterLoader : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject characterCirclePrefab;
    public TMP_Text greetingText;

    void Start()
    {
        Debug.Log("gelen karakter: " + CharacterHolder.Instance.SelectedCharacter);

        if (CharacterHolder.Instance.SelectedCharacter != null)
        {
            // 1. Karakteri oluþtur
            GameObject karakter = Instantiate(CharacterHolder.Instance.SelectedCharacter);

            // 2. Canvas altýna al
            GameObject canvas = GameObject.Find("Canvas");
            karakter.transform.SetParent(canvas.transform, false);

            // 3. Spawn noktasýna yerleþtir
            karakter.transform.localPosition = spawnPoint.localPosition;

            // 4. Daire zemin (arkaplan) oluþtur ve karakterin arkasýna koy
            GameObject zemin = Instantiate(characterCirclePrefab);
            zemin.transform.SetParent(canvas.transform, false);
            zemin.transform.localPosition = karakter.transform.localPosition + new Vector3(0, 0, 0.1f); // Arkaya koymak için z verildi

            // 5. Selamlaþma yazýsý
            string karakterAdi = karakter.name.Replace("(Clone)", "").Replace("Character_", "");
            greetingText.text = "Merhaba!\nBen " + karakterAdi + "! Harika bir macera bizi bekliyor";
        }
        else
        {
            Debug.LogWarning("Karakter seçilmedi!");
        }
    }
}