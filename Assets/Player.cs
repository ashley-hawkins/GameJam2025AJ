using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


public class Player
{
    Random rng = new Random();
    CardTarget playerTarget;
    int defence;
    int attack;
    List<Card> deck;
    List<Card> hand;

    CardHandDisplay handDisplay;

    public Player(CardHandDisplay handDisplay)
    {
        UnityEngine.Debug.Log("aaaa1");
        this.handDisplay = handDisplay;
        deck = Deck.GetStandardDeck();
        ShuffleDeck();
        hand = new List<Card>();
        ReplenishHand(7);
        handDisplay.DisplayHand(hand);
        UnityEngine.Debug.Log("aaaa");
    }

    public void ReplenishHand(int handSize)
    {
        for (int i = hand.Count; i < handSize; ++i)
        {
            if (deck.Count == 0)
            {
                break;
            }
            hand.Add(deck[0]);
            deck.RemoveAt(0);
        }
    }
    // def shuffle(numbers: list[int]) -> list[int]:
    //     for i in range(len(numbers) - 1, 0, -1):
    //         j = random.randint(0, i)
    //         numbers[i], numbers[j] = numbers[j], numbers[i]
    //     return numbers

    public void ShuffleDeck()
    {
        for (int i = deck.Count - 1; i > 0; --i)
        {
            int j = rng.Next(0, i + 1);
            var temp = deck[i];
            deck[i] = deck[j];
            deck[j] = temp;
        }
    }
}
