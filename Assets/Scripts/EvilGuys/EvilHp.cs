using UnityEngine;

public class EvilHp : Health
{
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if (CurrentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
