using UnityEngine;
using TMPro;

public class BilgiKutusuManager : MonoBehaviour
{
    public GameObject bilgiKutusu;
    public TextMeshProUGUI bilgiMetni;

    void Start()
    {
        bilgiKutusu.SetActive(false); // Sahne ba��nda kutuyu gizle
    }

    public void BilgiGoster(string metin)
    {
        Debug.Log("BilgiGoster fonksiyonu �a�r�ld�.");
        bilgiKutusu.SetActive(true);
        bilgiMetni.text = metin;
        Debug.Log("G�sterilen bilgi: " + metin);
    }

    public void BilgiKapat()
    {
        bilgiKutusu.SetActive(false);
        Debug.Log("Bilgi kutusu kapat�ld�.");
    }
}