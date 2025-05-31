using UnityEngine.EventSystems;
using UnityEngine;

using System.Collections;

public class IconReaction : MonoBehaviour, IPointerClickHandler
{
    public float scaleAmount = 1.2f;
    public float duration = 0.2f;
    public float rotateAmount = 15f;

    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(AnimateIcon());
    }

    IEnumerator AnimateIcon()
    {
        Vector3 originalScale = transform.localScale;
        Vector3 targetScale = originalScale * scaleAmount;

        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            transform.localScale = Vector3.Lerp(originalScale, targetScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            transform.localScale = Vector3.Lerp(targetScale, originalScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        float rotateElapsed = 0f;
        Quaternion originalRotation = transform.rotation;
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, rotateAmount);
        while (rotateElapsed < duration)
        {
            transform.rotation = Quaternion.Lerp(originalRotation, targetRotation, rotateElapsed / duration);
            rotateElapsed += Time.deltaTime;
            yield return null;
        }
    }
}