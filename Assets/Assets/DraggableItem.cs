using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public string itemName;

    private Vector3 originalPosition;
    private CanvasGroup canvasGroup;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPosition = transform.position;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    // ✅ Doğru bırakıldığında animasyon
    public IEnumerator CorrectFeedback(Transform dropZone)
    {
        float jumpHeight = 30f;
        float duration = 0.2f;
        Vector3 originalPos = transform.position;

        // Zıplama
        Vector3 upPos = originalPos + Vector3.up * jumpHeight;
        float elapsed = 0f;
        while (elapsed < duration)
        {
            transform.position = Vector3.Lerp(originalPos, upPos, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Parlama (renk efekti gibi)
        GetComponent<CanvasGroup>().alpha = 0.5f;
        yield return new WaitForSeconds(0.3f);
        GetComponent<CanvasGroup>().alpha = 1f;

        // Kartı sabitle (artık sürüklenemesin istersen burada disable edebilirsin)
        transform.position = dropZone.position;
        this.enabled = false;
    }

    // ❌ Yanlış bırakıldığında animasyon
    public IEnumerator IncorrectFeedback()
    {
        float shakeAmount = 10f;
        float duration = 0.3f;
        float elapsed = 0f;

        Vector3 startPos = originalPosition;

        while (elapsed < duration)
        {
            float x = Random.Range(-shakeAmount, shakeAmount);
            transform.position = startPos + new Vector3(x, 0, 0);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = originalPosition;
    }
}