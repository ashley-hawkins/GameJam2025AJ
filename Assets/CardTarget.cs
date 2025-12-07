using System;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class CardTarget
{
    struct HealingOverTime
    {
        public int healPerTurn;
        public int remainingDuration;
    }
    public int health { get; private set; }
    public int maxHealth { get; private set; }
    public int attackPercentage { get; private set; }
    public int defencePercentage { get; private set; }
    public int globalBuffPercentage { get; private set; }
    public int immediateBuffPercentage { get; private set; }

    private List<HealingOverTime> healingOverTime;
    // public int singleCardEffectIncreasePercent;


    public CardTarget(int hp, int maxHp)
    {
        health = hp;
        maxHealth = maxHp;
        attackPercentage = 100;
        defencePercentage = 100;
        globalBuffPercentage = 0;
        immediateBuffPercentage = 0;
        healingOverTime = new List<HealingOverTime>();
    }

    public bool IsDead()
    {
        return health <= 0;
    }

    public void ApplyEffect(CardInfusion.Effect effect)
    {
        effect = effect.Buffed(immediateBuffPercentage + globalBuffPercentage);
        /*
        public int attackChangePercent; DONE
        public int defenceChangePercent; DONE
        public int healthChangePercent; DONE
        public int healOverTimePercent; DONE
        public int splashDamage;
        public int globalBuffChangePercent; DONE
        public int singleCardEffectIncreasePercent; DONE
        public int randomHealthChangeRangeMin; DONE
        public int randomHealthChangeRangeMax; DONE
        */
        if (effect.randomHealthChangeRangeMin != 0 || effect.randomHealthChangeRangeMax != 0)
        {
            Random rng = new Random();
            int change = rng.Next(effect.randomHealthChangeRangeMin, effect.randomHealthChangeRangeMax + 1);
            health += change;
            health = Math.Min(health, maxHealth);
        }

        if (effect.healthChangePercent != 0)
        {
            health += effect.healthChangePercent * maxHealth / 100;
            health = Math.Min(health, maxHealth);
        }

        if (effect.healOverTimePercent != 0)
        {
            HealingOverTime hot = new HealingOverTime();
            hot.healPerTurn = effect.healOverTimePercent * maxHealth / 100;
            hot.remainingDuration = 3; // Hardcoded duration for now
            healingOverTime.Add(hot);
        }

        if (effect.globalBuffChangePercent != 0)
        {
            globalBuffPercentage += effect.globalBuffChangePercent;
        }

        if (effect.singleCardEffectIncreasePercent != 0)
        {
            immediateBuffPercentage += effect.singleCardEffectIncreasePercent;
        }

        if (effect.attackChangePercent != 0)
        {
            attackPercentage += effect.attackChangePercent;
        }

        if (effect.defenceChangePercent != 0)
        {
            defencePercentage += effect.defenceChangePercent;
        }
        immediateBuffPercentage = 0;
    }

    public void EndTurn()
    {
        globalBuffPercentage = 0;
        for (int i = healingOverTime.Count - 1; i >= 0; --i)
        {
            var hot = healingOverTime[i];
            health += hot.healPerTurn;
            health = Math.Min(health, maxHealth);
            hot.remainingDuration -= 1;
            if (hot.remainingDuration <= 0)
            {
                healingOverTime.RemoveAt(i);
            }
            else
            {
                healingOverTime[i] = hot;
            }
        }
    }
}
