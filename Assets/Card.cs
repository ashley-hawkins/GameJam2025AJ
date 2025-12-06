public struct Card
{
    public enum Suit
    {
        Heart,
        Diamond,
        Club,
        Spade
    }

    public enum Rank
    {
        N1,
        N2,
        N3,
        N4,
        N5,
        N6,
        N7,
        N8,
        N9,
        N10,
        Jack,
        Queen,
        King,
        Ace
    }

    public enum Infusion
    {
        Fire,
        Ice,
        Lightning,
        Special
    }

    public Suit suit;
    public Rank rank;
    public Infusion infusion;
}
