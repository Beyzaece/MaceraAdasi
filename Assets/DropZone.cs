using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public string correctItemName; // �rn: "Sushi", "Pizza", "Mant�"

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
                    Debug.Log("Do�ru e�le�tirme yap�ld�!");

                    // Do�ru yer: z�pla ve par�lda
                    StartCoroutine(draggable.CorrectFeedback(transform));
                }
                else
                {
                    Debug.Log("Yanl�� e�le�tirme!");

                    // Yanl��sa titreyip geri d�n
                    StartCoroutine(draggable.IncorrectFeedback());
                }
            }
        }
    }
}