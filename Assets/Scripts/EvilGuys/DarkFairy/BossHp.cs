using System;
using UnityEngine;

public class BossHp : Health
{
    [HideInInspector] public bool BossKilled;

    public static event Action BossDied;

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        BossDie();
    }
    private void BossDie()
    {
        if (currentHp <= 0)
        {
            BossKilled = true;
            BossDied?.Invoke();
            Destroy(gameObject);
        }
        else
        {
            BossKilled = false;
        }
    }
}
