using UnityEngine;
using System.IO;

public class ScreenshotManager : MonoBehaviour
{
    public void CaptureScreenshot()
    {
        string filename = "screenshot_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
        string path = Path.Combine(Application.persistentDataPath, filename);

        ScreenCapture.CaptureScreenshot(path);
        Debug.Log("Ekran görüntüsü alýndý: " + path);
    }
}