using UnityEngine;

public class BossHp : Health
{
    [HideInInspector] public bool BossKilled;
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if (currentHp <= 0)
        {
            BossKilled = true;
            Destroy(gameObject);
        }
    }
}
