using UnityEngine;
using UnityEngine.UI;

public class DurbunKontrol : MonoBehaviour
{
    public Camera mainCamera;
    public Button zoomButton;

    private bool isZoomed = false;

    void Start()
    {
        // PlayerPrefs'ten seçilen ekipmaný kontrol et
        string secilenEkipman = PlayerPrefs.GetString("secilenEkipman");

        if (secilenEkipman == "dürbünbutton")
        {
            zoomButton.gameObject.SetActive(true);
            zoomButton.onClick.AddListener(ToggleZoom);
        }
        else
        {
            zoomButton.gameObject.SetActive(false);
        }
    }

    void ToggleZoom()
    {
        if (!isZoomed)
        {
            mainCamera.fieldOfView = 30f; // Yakýnlaþtýr
            isZoomed = true;
        }
        else
        {
            mainCamera.fieldOfView = 60f; // Eski haline dön
            isZoomed = false;
        }
    }
}