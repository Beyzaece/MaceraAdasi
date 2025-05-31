using UnityEngine;
using TMPro; // TextMeshPro kullanıyorsan

public class AvatarOynatController : MonoBehaviour
{
    public Transform avatarSpawnPoint;
    public Transform aracSpawnPoint;
    public Transform ekipmanSpawnPoint;

    public GameObject[] avatarPrefabs;
    public GameObject[] aracPrefabs;
    public GameObject[] ekipmanPrefabs;

    public TextMeshProUGUI yeminMetniText;

    void Start()
    {
        Debug.Log(">> Gelen Seçim Verileri <<");
        Debug.Log("SecilenAvatarAdi: " + SecimVerisi.SecilenAvatarAdi);
        Debug.Log("SecilenAracAdi: " + SecimVerisi.SecilenAracAdi);
        Debug.Log("SecilenEkipmanAdi: " + SecimVerisi.SecilenEkipmanAdi);

        // === Avatarı Getir ===
        foreach (GameObject prefab in avatarPrefabs)
        {
            if (prefab.name == SecimVerisi.SecilenAvatarAdi)
            {
                GameObject avatarObj = Instantiate(prefab, avatarSpawnPoint.position, Quaternion.identity);
                avatarObj.transform.position -= new Vector3(1.8f, 1.5f, 0f);
                break;
            }
        }

        // === Aracı Getir ===
        foreach (GameObject prefab in aracPrefabs)
        {
            if (prefab.name == SecimVerisi.SecilenAracAdi)
            {
                GameObject aracObj = Instantiate(prefab, aracSpawnPoint.position, Quaternion.identity);
                aracObj.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f); // Ölçeği küçült
                aracObj.transform.position -= new Vector3(0.2f, 2.6f, 0f);
                break;
            }
        }

        // === Ekipmanı Getir ===
        foreach (GameObject prefab in ekipmanPrefabs)
        {
            if (prefab.name == SecimVerisi.SecilenEkipmanAdi)
            {
                GameObject ekipmanObj = Instantiate(prefab, ekipmanSpawnPoint.position, Quaternion.identity);
                ekipmanObj.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f); // Ölçeği küçült
                ekipmanObj.transform.position-= new Vector3(0f, 2.9f, 0f);
                break;
            }
        }

       
    }
}