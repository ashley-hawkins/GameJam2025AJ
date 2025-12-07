using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    System.Random rng = new System.Random();
    public CardTarget enemyTarget;
    int defence;
    int attack;
    int mana = 0;
    int maxMana = 3;
    public List<Card> deck;
    public List<Card> hand;


    public Enemy()
    {
        UnityEngine.Debug.Log("aaaa1");
        deck = Deck.GetStandardDeck();
        ShuffleDeck();
        hand = new List<Card>();
        ReplenishHand(7);
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

    public IEnumerator TakeTurn()
    {
        mana = maxMana;
        ReplenishHand(7);

        while (mana > 0 && hand.Count > 0 && !enemyTarget.IsDead())
        {
            var target = rng.Next(0, GameMaster.Instance.enemyTracker.EnemyCount() + 1);

            CardTarget cardTarget;
            if (target == 0)
            {
                cardTarget = GameMaster.Instance.PlayerTarget();
            }
            else
            {
                cardTarget = GameMaster.Instance.EnemyTarget(target - 1);
            }
            var cardIndex = rng.Next(0, hand.Count);
            var card = hand[cardIndex];
            var infusion = (Card.Infusion)rng.Next(0, 3);
            card.infusion = infusion;
            var effect = CardInfusion.InfusionResult(card);
            cardTarget.ApplyEffect(effect);
            RemoveCardFromHand(cardIndex);

            GameMaster.Instance.OutputText($"Enemy played {card} with {infusion} infusion on target {target}.\n" + effect.Describe());

            --mana;

            GameMaster.Instance.RefreshDisplays();

            yield return new WaitForSeconds(2.0f);
        }
    }
}
