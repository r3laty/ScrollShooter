using UnityEngine;

public class CharacterHp : Health
{
    public static bool IsDied;
    private float _maxHp;
    private void Start()
    {
        _maxHp = currentHp;
    }
    private void Update()
    {
        print(currentHp.ToString() + " Character health");
    }
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if (currentHp <= 0)
        {
            IsDied = true;
            Destroy(gameObject);
        }
    }
    public void Heal(int healthRestore)
    {
        if (!IsDied)
        {
            var maxHeal = Mathf.Max(_maxHp - currentHp, 0);
            var actualHeal = Mathf.Min(maxHeal, healthRestore);

            currentHp += actualHeal;
        }
    }
}
