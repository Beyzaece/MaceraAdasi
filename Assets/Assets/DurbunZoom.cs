using UnityEngine;

public class DurbunZoom : MonoBehaviour
{
    public Transform arCamera;         // ARCamera atanmalý
    public Transform model;            // Big Ben gibi 3D model atanmalý
    public float zoomSpeed = 1.5f;
    public float zoomDistance = 2f;    // Ne kadar yaklaþsýn

    private Vector3 originalPosition;
    private bool isZoomed = false;

    void Start()
    {
        originalPosition = arCamera.position;
    }

    public void ToggleZoom()
    {
        if (!isZoomed)
        {
            Vector3 direction = (model.position - arCamera.position).normalized;
            arCamera.position = model.position - direction * zoomDistance;
            isZoomed = true;
            Debug.Log("Zoom açýldý.");
        }
        else
        {
            arCamera.position = originalPosition;
            isZoomed = false;
            Debug.Log("Zoom kapatýldý.");
        }
    }
}