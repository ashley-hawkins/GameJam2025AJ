using NUnit.Framework.Interfaces;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CardInfusion
{
    public struct Effect
    {
        public int attackChangePercent;
        public int defenceChangePercent;
        public int healthChangePercent;
        public int healOverTimePercent;
        public int splashDamage;
        public int globalBuffChangePercent;
        public int singleCardEffectIncreasePercent;
        public int randomHealthChangeRangeMin;
        public int randomHealthChangeRangeMax;

        public string Describe()
        {
            string description = "Effect:";
            if (attackChangePercent != 0)
                description += $"\n - Attack Change Percent: {attackChangePercent}%";
            if (defenceChangePercent != 0)
                description += $"\n - Defence Change Percent: {defenceChangePercent}%";
            if (healthChangePercent != 0)
                description += $"\n - Health Change Percent: {healthChangePercent}%";
            if (healOverTimePercent != 0)
                description += $"\n - Heal Over Time Percent: {healOverTimePercent}%";
            if (splashDamage != 0)
                description += $"\n - Splash Damage: {splashDamage}";
            if (globalBuffChangePercent != 0)
                description += $"\n - Global Buff Change Percent: {globalBuffChangePercent}%";
            if (singleCardEffectIncreasePercent != 0)
                description += $"\n - Single Card Effect Increase Percent: {singleCardEffectIncreasePercent}%";
            if (randomHealthChangeRangeMin != 0 || randomHealthChangeRangeMax != 0)
                description += $"\n - Random Health Change Range: {randomHealthChangeRangeMin} to {randomHealthChangeRangeMax}";
            return description;
        }

        public string DescribeAsSentenceSingle(string subjectOfEffect, string objectOfEffect)
        {
            if (attackChangePercent > 0)
                return $"{subjectOfEffect} buffed {objectOfEffect}'s attack by {attackChangePercent}%";
            if (attackChangePercent < 0)
                return $"{subjectOfEffect} debuffed {objectOfEffect}'s attack by {-attackChangePercent}%";
            if (defenceChangePercent > 0)
                return $"{subjectOfEffect} buffed {objectOfEffect}'s defence by {defenceChangePercent}%";
            if (defenceChangePercent < 0)
                return $"{subjectOfEffect} debuffed {objectOfEffect}'s defence by {-defenceChangePercent}%";
            if (healthChangePercent > 0)
                return $"{subjectOfEffect} healed {objectOfEffect} by {healthChangePercent}%";
            if (healthChangePercent < 0)
                return $"{subjectOfEffect} damaged {objectOfEffect} by {-healthChangePercent}%";
            if (healOverTimePercent > 0)
                return $"{subjectOfEffect} slow-healed {objectOfEffect} by {healOverTimePercent}%";
            if (healOverTimePercent < 0)
                return $"{subjectOfEffect} slow-damaged {objectOfEffect} by {-healOverTimePercent}%";
            if (splashDamage > 0)
                return $"{subjectOfEffect} dealt {splashDamage} splash damage around {objectOfEffect}";
            if (globalBuffChangePercent > 0)
                return $"{subjectOfEffect} buffed {objectOfEffect} this turn by {globalBuffChangePercent}%";
            if (globalBuffChangePercent < 0)
                return $"{subjectOfEffect} debuffed {objectOfEffect} this turn by {-globalBuffChangePercent}%";
            if (singleCardEffectIncreasePercent > 0)
                return $"{subjectOfEffect} buffed {objectOfEffect}'s next card by {singleCardEffectIncreasePercent}%";
            if (randomHealthChangeRangeMin != 0 || randomHealthChangeRangeMax != 0)
                return $"{subjectOfEffect} changed {objectOfEffect}'s health by a random\namount between {randomHealthChangeRangeMin} and {randomHealthChangeRangeMax}";

            return "ERROR.";
            /*

        if (splashDamage != 0)
            description += $"Splash Damage: {splashDamage} ";
        if (globalBuffChangePercent != 0)
            description += $"Global Buff Change Percent: {globalBuffChangePercent}% ";
        if (singleCardEffectIncreasePercent != 0)
            description += $"Single Card Effect Increase Percent: {singleCardEffectIncreasePercent}% ";
        if (randomHealthChangeRangeMin != 0 || randomHealthChangeRangeMax != 0)
            description += $"Random Health Change Range: {randomHealthChangeRangeMin} to {randomHealthChangeRangeMax} ";
        return description.Trim();
    }
            */
        }

        public bool IsPositiveEffect()
        {
            return attackChangePercent > 0 || defenceChangePercent > 0 || healthChangePercent > 0 || healOverTimePercent > 0 || splashDamage < 0 || globalBuffChangePercent > 0 || singleCardEffectIncreasePercent > 0 || (randomHealthChangeRangeMin > 0 && randomHealthChangeRangeMax > 0);
        }


        public bool IsNegativeEffect()
        {
            return attackChangePercent < 0 || defenceChangePercent < 0 || healthChangePercent < 0 || healOverTimePercent < 0 || splashDamage > 0 || globalBuffChangePercent < 0 || singleCardEffectIncreasePercent < 0 || (randomHealthChangeRangeMin < 0 && randomHealthChangeRangeMax < 0);
        }

        public Effect Buffed(int buffPercentage)
        {
            var multiplier = (100 + buffPercentage) / 100;
            return new Effect
            {
                attackChangePercent = attackChangePercent * multiplier,
                defenceChangePercent = defenceChangePercent * multiplier,
                healthChangePercent = healthChangePercent * multiplier,
                healOverTimePercent = healOverTimePercent * multiplier,
                splashDamage = splashDamage * multiplier,
                globalBuffChangePercent = globalBuffChangePercent * multiplier,
                singleCardEffectIncreasePercent = singleCardEffectIncreasePercent * multiplier,
                randomHealthChangeRangeMin = randomHealthChangeRangeMin * multiplier,
                randomHealthChangeRangeMax = randomHealthChangeRangeMax * multiplier,
            };
        }
    }
    public static Effect InfusionResult(Card card)
    {
        if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Diamond)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { attackChangePercent = -card.rank.ToNumber() };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { attackChangePercent = -20 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { attackChangePercent = -30 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { attackChangePercent = -40 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { attackChangePercent = -50 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Heart)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { healthChangePercent = card.rank.ToNumber() };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { healthChangePercent = 20 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { healthChangePercent = 30 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { healthChangePercent = 40 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { healthChangePercent = 50 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Spade)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { attackChangePercent = card.rank.ToNumber() };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { attackChangePercent = 20 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { attackChangePercent = 30 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { attackChangePercent = 40 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { attackChangePercent = 50 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Fire && card.suit == Card.Suit.Club)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { globalBuffChangePercent = card.rank.ToNumber() };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { globalBuffChangePercent = 20 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { globalBuffChangePercent = 30 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { globalBuffChangePercent = 40 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { globalBuffChangePercent = 50 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Diamond)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { defenceChangePercent = card.rank.ToNumber() };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { defenceChangePercent = -20 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { defenceChangePercent = -30 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { defenceChangePercent = -40 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { defenceChangePercent = -50 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Heart)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { healOverTimePercent = card.rank.ToNumber() };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { healOverTimePercent = 10 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { healOverTimePercent = 15 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { healOverTimePercent = 20 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { healOverTimePercent = 25 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Spade)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { splashDamage = card.rank.ToNumber() / 2 };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { splashDamage = 10 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { splashDamage = 15 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { splashDamage = 20 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { splashDamage = 25 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Ice && card.suit == Card.Suit.Club)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { globalBuffChangePercent = card.rank.ToNumber() };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { globalBuffChangePercent = 20 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { globalBuffChangePercent = 30 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { globalBuffChangePercent = 40 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { globalBuffChangePercent = 50 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Diamond)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { attackChangePercent = card.rank.ToNumber() };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { attackChangePercent = 20 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { attackChangePercent = 30 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { attackChangePercent = 40 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { attackChangePercent = 50 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Heart)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { healOverTimePercent = -card.rank.ToNumber() / 2 };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { healOverTimePercent = -10 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { healOverTimePercent = -15 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { healOverTimePercent = -20 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { healOverTimePercent = -25 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Spade)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { randomHealthChangeRangeMin = card.rank.ToNumber() / 2, randomHealthChangeRangeMax = card.rank.ToNumber() * 2 };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { randomHealthChangeRangeMin = 10, randomHealthChangeRangeMax = 40 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { randomHealthChangeRangeMin = 15, randomHealthChangeRangeMax = 60 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { randomHealthChangeRangeMin = 20, randomHealthChangeRangeMax = 80 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { randomHealthChangeRangeMin = 25, randomHealthChangeRangeMax = 100 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else if (card.infusion == Card.Infusion.Lightning && card.suit == Card.Suit.Club)
        {
            if (card.rank.IsNumberCard())
            {
                return new Effect { singleCardEffectIncreasePercent = card.rank.ToNumber() * 2 };
            }
            else if (card.rank == Card.Rank.Jack)
            {
                return new Effect { singleCardEffectIncreasePercent = 40 };
            }
            else if (card.rank == Card.Rank.Queen)
            {
                return new Effect { singleCardEffectIncreasePercent = 60 };
            }
            else if (card.rank == Card.Rank.King)
            {
                return new Effect { singleCardEffectIncreasePercent = 80 };
            }
            else if (card.rank == Card.Rank.Ace)
            {
                return new Effect { singleCardEffectIncreasePercent = 100 };
            }
            else
            {
                throw new System.Exception("Invalid card rank");
            }
        }
        else
        {
            throw new System.Exception("Invalid card infusion or suit");
        }
    }
}
