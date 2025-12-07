using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IconButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private Sprite regularSprite;
    [SerializeField]
    private Sprite highlightedSprite;

    private bool isHovered = false;
    public bool isSelected { get; private set; } = false;

    public void Highlight()
    {
        var image = GetComponent<Image>();
        if (image != null)
        {
            image.sprite = highlightedSprite;
        }
    }

    void UpdateHighlighting()
    {
        if (isSelected || isHovered)
        {
            Highlight();
        }
        else
        {
            var image = GetComponent<Image>();
            if (image != null)
            {
                image.sprite = regularSprite;
            }
        }
    }

    public void Start()
    {
        UpdateHighlighting();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovered = true;
        UpdateHighlighting();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovered = false;
        UpdateHighlighting();
    }

    public void ToggleSelection()
    {
        isSelected = !isSelected;
        if (isSelected)
        {
            for (int i = 0; i < transform.parent.childCount; i++)
            {
                if (transform.GetSiblingIndex() == i) continue;
                var sibling = transform.parent.GetChild(i).GetComponent<IconButton>();
                if (sibling != null && sibling != this)
                {
                    sibling.isSelected = false;
                    sibling.UpdateHighlighting();
                }
            }
        }
    }
}
