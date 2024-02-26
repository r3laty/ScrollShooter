using UnityEngine;

public class BossHp : Health
{
    [SerializeField] private ShowTipAboutNewType tipController;
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if (currentHp <= 0)
        {
            StartCoroutine(tipController.ShowTip());
            Destroy(gameObject);
        }
    }
}
