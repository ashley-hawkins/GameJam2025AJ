using NUnit.Framework.Interfaces;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CardInfusion
{
    public string InfusionType(Card card)
    {
        if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Diamond){
            if (card.rank == Card.Rank.N1)
            {
                return "take negative effects from the target and give to the caster";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "if receiver is weak to fire, increase the following by 100%: damage reduced by 5%";
            }
            else if(card.rank == Card.Rank.N3)
            {
                return "if receiver is weak to fire, increase the following by 100%: damage increased by 5%";
            }
            else if(card.rank == Card.Rank.N4)
            {
                return "if receiver is weak to fire, increase the following by 100 %: damage received decreased by 5%";
            }
            else if(card.rank == Card.Rank.N5)
            {
                return "if receiver is weak to fire, increase the following by 100 %: damage received increased by 5%";
            }
            else if(card.rank == Card.Rank.N6)
            {
                return "if receiver is weak to fire, increase the following by 100 %: deal damage for 1 hp per turn for 2 turns";
            }
            else if(card.rank == Card.Rank.N7)
            {
                return "if receiver is weak to fire, increase the following by 100 %: damage reduced by 20%";
            }
            else if(card.rank == Card.Rank.N8)
            {
                return "if receiver is weak to fire, increase the following by 100 %: damage increased by 20%";
            }
            else if(card.rank == Card.Rank.N9)
            {
                return "if receiver is weak to fire, increase the following by 100 %: damage received decreased by 20%";
            }
            else if(card.rank == Card.Rank.N10)
            {
                return "if receiver is weak to fire, increase the following by 100 %: damage received increased by 20%";
            }
            else if(card.rank == Card.Rank.Jack)
            {
                return "if receiver is weak to fire, increase the following by 100 %: damage by 10% max per turn for 6 turns";
            }
            else if(card.rank == Card.Rank.Queen)
            {
                return "if receiver is weak to fire, increase the following by 100 %: damage out increased by 50% and damage received decreased by 50%";
            }
            else if(card.rank == Card.Rank.King)
            {
                return "if receiver is weak to fire, increase the following by 100 %: damage out reduced by 50% and damage received increased by 50%";
            }
            else if(card.rank == Card.Rank.Ace)
            {
                return "if receiver is weak to fire, increase the following by 100 %: reduces damage out to 0 for 1 turn and damages by 20% per turn for 4 turns";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Heart)
        {
            if (card.rank == Card.Rank.N1)
            {
                return " ";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "if receiver is weak to fire, increase the following by 100 %:";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Spade)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Club)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Diamond)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "take negative effects from the target and give to the caster";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "if receiver is weak to ice, increase the following by 100%: damage reduced by 5%";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "if receiver is weak to ice, increase the following by 100%: damage increased by 5%";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "if receiver is weak to ice, increase the following by 100 %: damage received decreased by 5%";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "if receiver is weak to ice, increase the following by 100 %: damage received increased by 5%";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "if receiver is weak to ice, increase the following by 100 %: deal damage for 1 hp per turn for 2 turns";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "if receiver is weak to ice, increase the following by 100 %: damage reduced by 20%";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "if receiver is weak to ice, increase the following by 100 %: damage increased by 20%";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "if receiver is weak to ice, increase the following by 100 %: damage received decreased by 20%";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "if receiver is weak to ice, increase the following by 100 %: damage received increased by 20%";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "if receiver is weak to ice, increase the following by 100 %: damage by 10% max per turn for 6 turns";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "if receiver is weak to ice, increase the following by 100 %: damage out increased by 50% and damage received decreased by 50%";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "if receiver is weak to ice, increase the following by 100 %: damage out reduced by 50% and damage received increased by 50%";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "if receiver is weak to ice, increase the following by 100 %: reduces damage out to 0 for 1 turn and damages by 20% per turn for 4 turns";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Heart)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Spade)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Club)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Diamond)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "take negative effects from the target and give to the caster";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "if receiver is weak to lighning, increase the following by 100%: damage reduced by 5%";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "if receiver is weak to lighning, increase the following by 100%: damage increased by 5%";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: damage received decreased by 5%";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: damage received increased by 5%";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: deal damage for 1 hp per turn for 2 turns";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: damage reduced by 20%";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: damage increased by 20%";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: damage received decreased by 20%";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: damage received increased by 20%";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: damage by 10% max per turn for 6 turns";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: damage out increased by 50% and damage received decreased by 50%";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: damage out reduced by 50% and damage received increased by 50%";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "if receiver is weak to lightning, increase the following by 100 %: reduces damage out to 0 for 1 turn and damages by 20% per turn for 4 turns";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Heart)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Spade)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Club)
        {
            if (card.rank == Card.Rank.N1)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N2)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N3)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N4)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N5)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N6)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N7)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N8)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N9)
            {
                return "";
            }
            else if (card.rank == Card.Rank.N10)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return "";
            }
            else if (card.rank == Card.Rank.King)
            {
                return "";
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return "";
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
