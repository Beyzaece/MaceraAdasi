using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public string correctItemName; // Örn: "Sushi", "Pizza", "Mantý"

    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObject = eventData.pointerDrag;

        if (droppedObject != null)
        {
            DraggableItem draggable = droppedObject.GetComponent<DraggableItem>();
            if (draggable != null)
            {
                if (draggable.itemName == correctItemName)
                {
                    Debug.Log("Doðru eþleþtirme yapýldý!");

                    // Doðru yer: zýpla ve parýlda
                    StartCoroutine(draggable.CorrectFeedback(transform));
                }
                else
                {
                    Debug.Log("Yanlýþ eþleþtirme!");

                    // Yanlýþsa titreyip geri dön
                    StartCoroutine(draggable.IncorrectFeedback());
                }
            }
        }
    }
}