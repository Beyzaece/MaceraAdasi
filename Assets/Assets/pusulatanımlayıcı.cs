using UnityEngine;
using Vuforia;

public class PusulaTanimlayici : MonoBehaviour
{
    public GameObject karakter;
    public GameObject soruPaneli;

    void Start()
    {
        karakter.SetActive(false);
        soruPaneli.SetActive(false);
    }

    public void OnTrackingFound()
    {
        karakter.SetActive(true);
        soruPaneli.SetActive(true);
    }

    public void OnTrackingLost()
    {
        karakter.SetActive(false);
        soruPaneli.SetActive(false);
    }
}