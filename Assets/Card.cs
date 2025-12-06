using static Card;

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
    public Infusion? infusion;
}

static class CardExtensions
{
    public static bool IsFaceCard(this Rank rank)
    {
        return rank == Rank.Jack || rank == Rank.Queen || rank == Rank.King;
    }

    public static bool IsNumberCard(this Rank rank)
    {
        return rank >= Rank.N1 && rank <= Rank.N10;
    }

    public static int ToNumber(this Rank rank)
    {
        if (rank.IsNumberCard())
        {
            return (int)rank + 1;
        }
        throw new System.ArgumentException("Rank is not a number card");
    }
}
