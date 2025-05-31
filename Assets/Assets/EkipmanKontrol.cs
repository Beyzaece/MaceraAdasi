using UnityEngine;
using UnityEngine.UI;

public class EkipmanKontrol : MonoBehaviour
{
    public GameObject fotoCekButton;

    void Start()
    {
        // Se�ilen ekipman� PlayerPrefs'ten kontrol ediyoruz
        string secilenEkipman = SecimVerisi.SecilenEkipmanAdi;

        if (secilenEkipman == "fotomakbutton")
        {
            fotoCekButton.SetActive(true);
        }
        else
        {
            fotoCekButton.SetActive(false);
        }
    }
}