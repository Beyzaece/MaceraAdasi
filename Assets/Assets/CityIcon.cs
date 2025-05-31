using UnityEngine;

public class CityIcon : MonoBehaviour
{
    public Sprite cityImage;

    [TextArea(3, 5)]
    public string cityDescription;

    public InfoCardController cardController;

    public GameObject roketPrefab;
    public GameObject balonPrefab;
    public GameObject ucakPrefab;
    public GameObject halıPrefab;

    public void OnClick()
    {
        GameObject aracPrefab = null;

        switch (SecimVerisi.SecilenAracAdi)
        {
            case "roketbutton":
                aracPrefab = roketPrefab;
                break;
            case "balonbutton":
                aracPrefab = balonPrefab;
                break;
            case "ucakbutton":
                aracPrefab = ucakPrefab;
                break;
            case "halıbutton":
                aracPrefab = halıPrefab;
                break;
            default:
                Debug.LogWarning("Araç seçilmedi veya tanımlı değil.");
                return;
        }

        Vector3 hedefKonum = transform.position;
        hedefKonum.z = 1f; // Kartın arkasında kalmasın

        VehicleFlyer flyer = FindObjectOfType<VehicleFlyer>();
        flyer.FlyToTargetWith(aracPrefab, hedefKonum, () =>
        {
            cardController.ShowCard(cityImage, cityDescription);
        });
    }
}