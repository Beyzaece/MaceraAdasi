using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public Transform spawnPoint; // Burasý eksikti, bu satýrý mutlaka ekle!

    void Start()
    {
        Debug.Log("gelen karakter: " + CharacterHolder.Instance.SelectedCharacter);

        if (CharacterHolder.Instance.SelectedCharacter != null)
        {
            // 1. Karakteri oluþtur
            GameObject karakter = Instantiate(CharacterHolder.Instance.SelectedCharacter);
            karakter.transform.position = spawnPoint.position;


            // 2. Canvas altýna al
            GameObject canvas = GameObject.Find("Canvas");
            karakter.transform.SetParent(canvas.transform, false);

            // 3. Spawn noktasýna yerleþtir
            karakter.transform.localPosition = spawnPoint.localPosition;

            

       
        }
        else
        {
            Debug.LogWarning("Karakter seçilmedi!");
        }
    }
}