using UnityEngine;
using UnityEngine.UI;

public class DurbunKontrol : MonoBehaviour
{
    public Camera mainCamera;
    public Button zoomButton;

    private bool isZoomed = false;

    void Start()
    {
        // PlayerPrefs'ten se�ilen ekipman� kontrol et
        string secilenEkipman = PlayerPrefs.GetString("secilenEkipman");

        if (secilenEkipman == "d�rb�nbutton")
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
            mainCamera.fieldOfView = 30f; // Yak�nla�t�r
            isZoomed = true;
        }
        else
        {
            mainCamera.fieldOfView = 60f; // Eski haline d�n
            isZoomed = false;
        }
    }
}