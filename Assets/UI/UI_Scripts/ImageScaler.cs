using UnityEngine;
using UnityEngine.UI;

public class ImageScaler : MonoBehaviour
{
    RectTransform imageContainer;
    Image image;

    void Start()
    {
        imageContainer = GetComponent<RectTransform>();
        image = GetComponentInChildren<Image>();

        ScaleImage();
    }

    void ScaleImage()
    {
        float containerWidth = imageContainer.rect.width;
        float containerHeight = imageContainer.rect.height;

        float spriteWidth = image.sprite.rect.width;
        float spriteHeight = image.sprite.rect.height;

        float containerAspect = (float) (containerWidth / containerHeight);
        float spriteAspect = (float) (spriteWidth / spriteHeight);
       
        if (containerAspect > spriteAspect)
        {
            // sprite�� height�� �� �� ���
            float newWidth = containerWidth;
            float newHeight = (float) (newWidth / spriteAspect);

            image.rectTransform.sizeDelta = new Vector2(newWidth, newHeight);
            image.rectTransform.anchoredPosition = new Vector2(0, (newHeight - containerHeight) / 2);
        }
        else
        {
            float newHeight = containerHeight;
            float newWidth = (float) (newHeight * spriteAspect);

            image.rectTransform.sizeDelta = new Vector2(newWidth, newHeight);  
            image.rectTransform.anchoredPosition = new Vector2((newHeight - containerHeight) / 2, 0);
        }

    }

    private void OnRectTransformDimensionsChange()
    {
        imageContainer = GetComponent<RectTransform>();
        image = GetComponentInChildren<Image>();
        ScaleImage();
    }
}