using System.Collections;
using UnityEngine;

public class EnemyTracker : MonoBehaviour
{
    public int EnemyCount()
    {
        return transform.childCount;
    }

    public Enemy GetEnemyAtIndex(int index)
    {
        if (index < 0 || index >= transform.childCount)
        {
            return null;
        }
        return transform.GetChild(index).GetComponent<Enemy>();
    }

    public IEnumerator TakeEnemiesTurns()
    {
        bool anyAlive = false;
        for (int i = 0; i < EnemyCount(); ++i)
        {
            print("Enemy " + i + " taking turn.");
            print("Current health: " + GetEnemyAtIndex(i).enemyTarget.health);
            var enemy = GetEnemyAtIndex(i);
            if (enemy != null && !enemy.enemyTarget.IsDead())
            {
                anyAlive = true;
                yield return enemy.TakeTurn();
            }
        }

        if (!anyAlive)
        {
            GameMaster.Instance.OutputText("All enemies defeated! You win!");
        }
        GameMaster.Instance.BeginPlayerTurn();
    }
}
