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
    private bool _permanentlyHighlighted = false;
    public bool PermanentlyHighlighted
    {
        get { return _permanentlyHighlighted; }
        set
        {
            _permanentlyHighlighted = value;
            UpdateHighlighting();
        }
    }


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
        if (_permanentlyHighlighted || isHovered)
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
}
