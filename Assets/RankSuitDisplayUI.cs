using UnityEngine;
using UnityEngine.UI;
using static Card;

public class RankSuitDisplayUI : MonoBehaviour
{
    [SerializeField]
    private Sprite[] rankSprites;
    [SerializeField]
    private Sprite[] suitSprites;

    [SerializeField]
    private Image suitRenderer;
    [SerializeField]
    private Image rankRenderer;
    public void UpdateDisplay(Rank rank, Suit suit)
    {
        suitRenderer.sprite = suitSprites[(int)suit];
        rankRenderer.sprite = rankSprites[(int)rank];
    }

    void Start()
    {
        // Test:
        // UpdateDisplay(Rank.N5, Suit.Diamond);
    }
}
