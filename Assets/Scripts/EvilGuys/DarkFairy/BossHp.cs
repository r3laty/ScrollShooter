using UnityEngine;

public class BossHp : Health
{
    public static bool KilledBoss;

    [SerializeField] private ShowTipAboutNewType tipController;
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if (currentHp <= 0)
        {
            StartCoroutine(tipController.ShowTip());
            KilledBoss = true;
            Destroy(gameObject);
        }
    }
}
