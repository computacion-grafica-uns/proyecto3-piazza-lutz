using UnityEngine;
using UnityEngine.UI;

public class CRTOverlayScroll : MonoBehaviour
{
    public RawImage rawImage;
    public float scrollSpeed = 0.03f;

    /*private void Start()
    {
        rawImage.uvRect = new Rect(rawImage.uvRect.x, rawImage.uvRect.y, 0.5f, 0.5f);
    }*/

    void Update()
    {
        if (rawImage != null)
        {
            Rect uvRect = rawImage.uvRect;
            uvRect.y += scrollSpeed * Time.deltaTime;
            rawImage.uvRect = uvRect;
        }
    }
}