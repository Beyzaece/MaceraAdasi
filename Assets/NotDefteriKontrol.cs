using UnityEngine;
using TMPro;

public class NotDefteriKontrol : MonoBehaviour
{
    public GameObject notdefteributton;   // Not defteri butonu (a�/kapat butonu)
    public GameObject InfoBox;           // Bilgi paneli (i�erik g�sterilecek alan)
    public TMP_Text InfoText;            // Bilgi yaz�s�

    void Start()
    {
        // Se�ilen ekipman� kontrol et
        string secilenEkipman = SecimVerisi.SecilenEkipmanAdi;
        Debug.Log("Se�ilen ekipman: " + secilenEkipman);

        // Sadece not defteri se�ildiyse butonu g�ster
        if (secilenEkipman == "notdefbutton")
        {
            notdefteributton.SetActive(true);
        }
        else
        {
            notdefteributton.SetActive(false);
        }

        // Ba�lang��ta bilgi paneli kapal� olsun
        InfoBox.SetActive(false);
    }

    // Butona t�klan�nca �a�r�lacak fonksiyon
    public void BilgiGoster(string bilgi)
    {
        InfoText.text = bilgi;
        InfoBox.SetActive(true);
    }

    // Paneli kapatma butonu i�in
    public void Kapat()
    {
        InfoBox.SetActive(false);
    }
}