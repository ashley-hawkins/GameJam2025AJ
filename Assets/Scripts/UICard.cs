using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool isHovered = false;
    private bool isSelected = false;
    private int raisedAmount = 0;
    [SerializeField]
    private Transform innerTransform;
    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovered = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovered = false;
    }

    public void Select()
    {
        isSelected = true;
    }

    public void Deselect()
    {
        isSelected = false;
    }

    public void Toggle()
    {
        isSelected = !isSelected;
    }

    public void Update()
    {
        var targetAmount = (isSelected ? 12 : 0) + (isHovered ? 9 : 0);
        if (raisedAmount < targetAmount)
            raisedAmount++;
        else if (raisedAmount > targetAmount)
            raisedAmount--;
        innerTransform.localPosition = new Vector3(innerTransform.localPosition.x, raisedAmount / 3, innerTransform.localPosition.z);
    }
}
