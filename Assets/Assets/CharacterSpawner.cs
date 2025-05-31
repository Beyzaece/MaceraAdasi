using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public Transform spawnPoint; // Buras� eksikti, bu sat�r� mutlaka ekle!

    void Start()
    {
        Debug.Log("gelen karakter: " + CharacterHolder.Instance.SelectedCharacter);

        if (CharacterHolder.Instance.SelectedCharacter != null)
        {
            // 1. Karakteri olu�tur
            GameObject karakter = Instantiate(CharacterHolder.Instance.SelectedCharacter);
            karakter.transform.position = spawnPoint.position;


            // 2. Canvas alt�na al
            GameObject canvas = GameObject.Find("Canvas");
            karakter.transform.SetParent(canvas.transform, false);

            // 3. Spawn noktas�na yerle�tir
            karakter.transform.localPosition = spawnPoint.localPosition;

            

       
        }
        else
        {
            Debug.LogWarning("Karakter se�ilmedi!");
        }
    }
}