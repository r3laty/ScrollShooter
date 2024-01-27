using UnityEngine;

public class Die : Health
{
    public static bool IsDied;

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if (_currentHp <= 0)
        {
            IsDied = true;
            Destroy(gameObject);
        }
    }
}
