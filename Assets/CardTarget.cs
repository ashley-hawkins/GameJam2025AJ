using System;
using System.Collections.Generic;
using UnityEngine;

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
    }

    public void healthDamage(int damage)
    {
        health = health - damage;
    }

    public void atkDrop(int damage)
    {
        attackPercentage = attackPercentage - damage;
    }

    public void defDrop(int damage)
    {
        defencePercentage = defencePercentage - damage;
    }
}
