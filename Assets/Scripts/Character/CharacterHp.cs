using UnityEngine;

public class CharacterHp : Health
{
    public bool IsDied;

    private float _maxHp;
    private void Start()
    {
        _maxHp = CurrentHp;
    }
    private void Update()
    {
        print(CurrentHp.ToString() + " Character health");
    }
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if (CurrentHp <= 0)
        {
            IsDied = true;
            Destroy(gameObject);
        }
    }
    public void Heal(int healthRestore)
    {
        if (!IsDied)
        {
            var maxHeal = Mathf.Max(_maxHp - CurrentHp, 0);
            var actualHeal = Mathf.Min(maxHeal, healthRestore);

            CurrentHp += actualHeal;
        }
    }
}
