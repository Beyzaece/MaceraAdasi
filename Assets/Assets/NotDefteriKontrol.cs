using UnityEngine;
using TMPro;

public class NotDefteriKontrol : MonoBehaviour
{
    public GameObject notdefteributton;   // Not defteri butonu (aç/kapat butonu)
    public GameObject InfoBox;           // Bilgi paneli (içerik gösterilecek alan)
    public TMP_Text InfoText;            // Bilgi yazýsý

    void Start()
    {
        // Seçilen ekipmaný kontrol et
        string secilenEkipman = SecimVerisi.SecilenEkipmanAdi;
        Debug.Log("Seçilen ekipman: " + secilenEkipman);

        // Sadece not defteri seçildiyse butonu göster
        if (secilenEkipman == "notdefbutton")
        {
            notdefteributton.SetActive(true);
        }
        else
        {
            notdefteributton.SetActive(false);
        }

        // Baþlangýçta bilgi paneli kapalý olsun
        InfoBox.SetActive(false);
    }

    // Butona týklanýnca çaðrýlacak fonksiyon
    public void BilgiGoster(string bilgi)
    {
        InfoText.text = bilgi;
        InfoBox.SetActive(true);
    }

    // Paneli kapatma butonu için
    public void Kapat()
    {
        InfoBox.SetActive(false);
    }
}