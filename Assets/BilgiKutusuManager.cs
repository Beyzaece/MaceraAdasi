using UnityEngine;
using TMPro;

public class BilgiKutusuManager : MonoBehaviour
{
    public GameObject bilgiKutusu;
    public TextMeshProUGUI bilgiMetni;

    void Start()
    {
        bilgiKutusu.SetActive(false); // Sahne baþýnda kutuyu gizle
    }

    public void BilgiGoster(string metin)
    {
        Debug.Log("BilgiGoster fonksiyonu çaðrýldý.");
        bilgiKutusu.SetActive(true);
        bilgiMetni.text = metin;
        Debug.Log("Gösterilen bilgi: " + metin);
    }

    public void BilgiKapat()
    {
        bilgiKutusu.SetActive(false);
        Debug.Log("Bilgi kutusu kapatýldý.");
    }
}