using System;
using System.Collections;
using UnityEngine;

public class VehicleFlyer : MonoBehaviour
{
    public void FlyToTargetWith(GameObject prefab, Vector3 targetPosition, Action onArrival)
    {
        // Canvas'a değil, sahneye instantiate et (UI değilse)
        GameObject vehicle = Instantiate(prefab);

       
        vehicle.transform.localScale = Vector3.one * 0.2f;

        // Başlangıç pozisyonunu belirle (ekran altından)
        Vector3 startScreenPos = new Vector3(Screen.width / 2, -200f, 10f);
        Vector3 startWorldPos = Camera.main.ScreenToWorldPoint(startScreenPos);

        vehicle.transform.position = startWorldPos;

        Debug.Log("Uçuş başlatılıyor: " + vehicle.name);

        // Uçuş animasyonu başlat
        StartCoroutine(FlyRoutine(vehicle.transform, targetPosition, onArrival));
    }

    IEnumerator FlyRoutine(Transform objTransform, Vector3 target, Action onArrival)
    {
        Vector3 start = objTransform.position;
        float duration = 5.5f;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float t = elapsed / duration;
            float easedT = EaseInOutCubic(t); // Yumuşak geçiş

            objTransform.position = Vector3.Lerp(start, target, easedT);
            elapsed += Time.deltaTime;
            yield return null;
        }

        objTransform.position = target;
        onArrival?.Invoke();
    }

    // EaseInOutCubic fonksiyonu:
    float EaseInOutCubic(float t)
    {
        return t < 0.5f
            ? 4f * t * t * t
            : 1f - Mathf.Pow(-2f * t + 2f, 3f) / 2f;
    }
}