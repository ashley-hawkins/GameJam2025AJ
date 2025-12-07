using System.Collections.Generic;
using UnityEngine;

public class CardHandDisplay : MonoBehaviour
{
    [SerializeField]
    private GameObject cardPrefab;
    public void DisplayHand(List<Card> hand)
    {
        while (transform.childCount < hand.Count)
        {
            Instantiate(cardPrefab, transform);
        }
        while (transform.childCount > hand.Count)
        {
            var child = transform.GetChild(0);
            child.SetParent(null);
            Destroy(child.gameObject);
        }
        for (int i = 0; i < hand.Count; i++)
        {
            var uiCard = transform.GetChild(i).GetComponent<UICard>();
            uiCard.DisplayCard(hand[i]);
            uiCard.gameObject.SetActive(true);
        }
    }

    public int SelectedIndex()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var uiCard = transform.GetChild(i).GetComponent<UICard>();
            if (uiCard != null && uiCard.isSelected)
            {
                return i;
            }
        }
        return -1;
    }

    public void DeselectAllBut(int indexToKeep)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (i != indexToKeep)
            {
                var uiCard = transform.GetChild(i).GetComponent<UICard>();
                if (uiCard != null)
                {
                    uiCard.Deselect();
                }
            }
        }
    }

    public void DeselectAll()
    {
        DeselectAllBut(-1);
    }
}
