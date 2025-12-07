using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


public class Player
{
    Random rng = new Random();
    public CardTarget playerTarget;
    public int defence;
    public int attack;
    public int mana = 0;
    public int maxMana = 3;
    public List<Card> deck;
    public List<Card> hand;

    CardHandDisplay handDisplay;

    public Player(CardHandDisplay handDisplay)
    {
        playerTarget = new CardTarget(100, 100);
        UnityEngine.Debug.Log("aaaa1");
        this.handDisplay = handDisplay;
        deck = Deck.GetStandardDeck();
        ShuffleDeck();
        hand = new List<Card>();
        ReplenishHand(7);
        mana = maxMana;
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

    public void RemoveCardFromHand(int index)
    {
        if (index < 0 || index >= hand.Count)
        {
            return;
        }
        var theCard = hand[index];
        hand.RemoveAt(index);
        deck.Insert(rng.Next(0, deck.Count + 1), theCard);
        handDisplay.DeselectAll();
        handDisplay.DisplayHand(hand);
    }

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
