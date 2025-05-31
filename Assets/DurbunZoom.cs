using UnityEngine;

public class DurbunZoom : MonoBehaviour
{
    public Transform arCamera;         // ARCamera atanmal�
    public Transform model;            // Big Ben gibi 3D model atanmal�
    public float zoomSpeed = 1.5f;
    public float zoomDistance = 2f;    // Ne kadar yakla�s�n

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
            Debug.Log("Zoom a��ld�.");
        }
        else
        {
            arCamera.position = originalPosition;
            isZoomed = false;
            Debug.Log("Zoom kapat�ld�.");
        }
    }
}