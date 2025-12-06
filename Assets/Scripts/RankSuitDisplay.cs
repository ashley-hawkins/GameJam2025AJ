using UnityEngine;
using static Card;

public class RankSuitDisplay : MonoBehaviour
{
    [SerializeField]
    private Animator suitAnim;
    [SerializeField]
    private Animator rankAnim;
    void UpdateDisplay(Rank rank, Suit suit)
    {
        const Rank maxRank = Rank.Ace;
        const Suit maxSuit = Suit.Spade;

        suitAnim.SetFloat("t", (float)suit / (float)(maxSuit + 1));
        rankAnim.SetFloat("t", (float)rank / (float)(maxRank + 1));
    }

    void Start()
    {
        UpdateDisplay(Rank.N5, Suit.Diamond);
    }
}
