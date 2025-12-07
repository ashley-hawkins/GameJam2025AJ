using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool isHovered = false;
    public bool isSelected { get; private set; } = false;
    private int raisedAmount = 0;
    [SerializeField]
    private Transform innerTransform;
    [SerializeField]
    private RankSuitDisplayUI rankSuitDisplayUI1;
    [SerializeField]
    private RankSuitDisplayUI rankSuitDisplayUI2;
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
        transform.parent.GetComponent<CardHandDisplay>().DeselectAllBut(transform.GetSiblingIndex());
    }

    public void Deselect()
    {
        isSelected = false;
    }

    public void Toggle()
    {
        isSelected = !isSelected;
        if (isSelected)
        {
            transform.parent.GetComponent<CardHandDisplay>().DeselectAllBut(transform.GetSiblingIndex());
        }
        GameMaster.Instance.OutputText(isSelected ? "Card selected." : "Card deselected.");
    }

    public void FixedUpdate()
    {
        var targetAmount = (isSelected ? 12 : 0) + (isHovered ? 9 : 0);
        if (raisedAmount < targetAmount)
            raisedAmount++;
        else if (raisedAmount > targetAmount)
            raisedAmount--;
        innerTransform.localPosition = new Vector3(innerTransform.localPosition.x, raisedAmount / 3, innerTransform.localPosition.z);
    }

    public void DisplayCard(Card card)
    {
        rankSuitDisplayUI1.UpdateDisplay(card.rank, card.suit);
        rankSuitDisplayUI2.UpdateDisplay(card.rank, card.suit);
    }
}
