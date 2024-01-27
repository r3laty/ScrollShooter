using UnityEngine;

public class Evil : Health
{
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if (_currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
