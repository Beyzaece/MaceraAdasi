using UnityEngine;

public class RotateWorld : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        // Y ekseni etraf�nda d�nd�rme
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}