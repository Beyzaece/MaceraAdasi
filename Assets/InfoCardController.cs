using TMPro;
using UnityEngine;

using UnityEngine.UI;

public class InfoCardController : MonoBehaviour
{
    public GameObject infoCard;
    public Image cityImage;
    public TextMeshProUGUI cityDescription;

    public void ShowCard(Sprite image, string description)
    {
        infoCard.SetActive(true);
        cityImage.sprite = image;
        cityDescription.text = description;
    }

    public void HideCard()
    {
        infoCard.SetActive(false);
    }
}