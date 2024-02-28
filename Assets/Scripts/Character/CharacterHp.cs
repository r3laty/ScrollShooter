using UnityEngine;

public class CharacterHp : Health
{
    public static bool IsDied;

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        print(currentHp + " character hp");
        if (currentHp <= 0)
        {
            IsDied = true;
            Destroy(gameObject);
        }
    }
}
