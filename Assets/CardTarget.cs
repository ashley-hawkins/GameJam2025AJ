using System;
using UnityEngine;

public class CardTarget 
{
    public int health { get; private set; }
    public int attackPercentage { get; private set; }
    public int defencePercentage { get; private set; }
    
    public CardTarget(int hp)
    {
        health = hp;
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
