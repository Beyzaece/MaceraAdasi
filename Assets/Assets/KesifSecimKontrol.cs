using UnityEngine;

public class KesifSecimKontrol : MonoBehaviour
{
    public enum SecimTuru
    {
        Ekipman,
        Arac
    }
    public SecimTuru secimTuru;
    private static GameObject secilenEkipman;
    private static GameObject secilenArac;
    private Vector3 ekipmanOrijinalBoyut;
    private Vector3 aracOrijinalBoyut;
    private Vector3 kendiOrijinalBoyut;

    void Start()
    {
        kendiOrijinalBoyut = transform.localScale;
    }

    public void SecimYap()
    {
        if (secimTuru == SecimTuru.Ekipman)
        {
            if (secilenEkipman != null && secilenEkipman != gameObject)
                secilenEkipman.transform.localScale = ekipmanOrijinalBoyut;

            secilenEkipman = gameObject;
            ekipmanOrijinalBoyut = kendiOrijinalBoyut;
            SecimVerisi.SecilenEkipmanAdi = gameObject.name;

            Debug.Log(">>> Seçilen ekipman: " + SecimVerisi.SecilenEkipmanAdi);
        }
        else if (secimTuru == SecimTuru.Arac)
        {
            if (secilenArac != null && secilenArac != gameObject)
                secilenArac.transform.localScale = aracOrijinalBoyut;

            secilenArac = gameObject;
            aracOrijinalBoyut = kendiOrijinalBoyut;
            SecimVerisi.SecilenAracAdi = gameObject.name;

            Debug.Log(">>> Seçilen araç: " + SecimVerisi.SecilenAracAdi);
        }

        transform.localScale = kendiOrijinalBoyut * 1.2f;
    }

    public static bool SecimTamamlandi()
    {
        return secilenEkipman != null && secilenArac != null;
    }
}