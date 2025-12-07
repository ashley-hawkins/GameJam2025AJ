using NUnit.Framework.Interfaces;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CardInfusion
{
    public string InfusionType(Card card)
    {
        if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Diamond) {
            if (card.rank.IsNumberCard())
            {
                return "Decrease attack by " + card.rank.ToNumber() + "%";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Decrease attack by 20%";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Decrease attack by 30%";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Decrease attack by 40%";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Decrease attack by 50%";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Heart)
        {
            if (card.rank.IsNumberCard())
            {
                return "Heal by " + card.rank.ToNumber() + "%";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Heal by 20%";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Heal by 30%";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Heal by 40%";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Heal by 50%";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Spade)
        {
            if (card.rank.IsNumberCard())
            {
                return "Deal " + card.rank.ToNumber() + " damage to a single target";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Deal 20 damage to a single target";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Deal 30 damage to a single target";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Deal 40 damage to a single target";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Deal 50 damage to a single target";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Club)
        {
            if (card.rank.IsNumberCard())
            {
                return "Increase card effects by " + card.rank.ToNumber() + "%";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Increase card effects by 20%";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Increase card effects by 30%";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Increase card effects by 40%";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Increase card effects by 50%";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Diamond)
        {
            if (card.rank.IsNumberCard())
            {
                return "increase defence by " + card.rank.ToNumber() + "%";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "increase defence by 20%";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Increase defence by 30%";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Increase defence by 40%";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Increase defence by 50%";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Heart)
        {
            if (card.rank.IsNumberCard())
            {
                return "Heal " + (card.rank.ToNumber()/2) + "% over time";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Heal 10% over time";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Heal by 15% over time";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Heal 20% over time";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Heal 25% over time";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Spade)
        {
            if (card.rank.IsNumberCard())
            {
                return "Deal " + (card.rank.ToNumber()/2) + " damage to all targets";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Deal 10 damage to all targets";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Deal 15 damage to all targets";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Deal 20 damage to all targets";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Deal 25 damage to all targets";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Club)
        {
            if (card.rank.IsNumberCard())
            {
                return "Decrease card effects by " + card.rank.ToNumber() + "%";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Decrease card effects by 20%";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Decrease card effects by 30%";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Decrease card effects by 40%";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Decrease card effects by 50%";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Diamond)
        {
            if (card.rank.IsNumberCard())
            {
                return "increase damage by " + card.rank.ToNumber() + "%";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "increase damage by 20%";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Increase damage by 30%";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Increase damage by 40%";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Increase damage by 50%";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Heart)
        {
            if (card.rank.IsNumberCard())
            {
                return "Deal " + (card.rank.ToNumber() / 2) + "% damage over time";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Deal 10% damage over time";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Deal 15% damage over time";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Deal 20% damage over time";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Deal 25% damage over time";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Spade)
        {
            if (card.rank.IsNumberCard())
            {
                return "Deal " + (card.rank.ToNumber() / 2) + " to " + (card.rank.ToNumber()*2) + " damage to a single target";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Deal 10 - 40 damage to a single target";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Deal 15 - 60 damage to a single target";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Deal 20 - 80 damage to a single target";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Deal 25 - 100 damage to a single target";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Club)
        {
            if (card.rank.IsNumberCard())
            {
                return "Increase a single card effect by " + (card.rank.ToNumber() * 2) + "%";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "Increase a single card effect by 40%";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "Increase a single card effect by 60%";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "Increase a single card effect by 80%";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "Increase a single card effect by 100%";
            }
            else
            {
                return "";
            }
        }
        else
        {
            return "";
        }
    }
}
