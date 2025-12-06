using System;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    public static List<Card> GetStandardDeck()
    {
        List<Card> result = new();

        foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
        {
            for (int i = (int)Card.Rank.N2; i <= (int)Card.Rank.Ace; ++i)
            {
                result.Add(
                    new Card
                    {
                        infusion = null,
                        rank = (Card.Rank)i,
                        suit = suit
                    }
                  );
            }
        }
        return result;
    }
}
