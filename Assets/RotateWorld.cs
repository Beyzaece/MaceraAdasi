using UnityEngine;

public class RotateWorld : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        // Y ekseni etrafýnda döndürme
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}