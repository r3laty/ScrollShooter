using UnityEngine;

public class Health : MonoBehaviour
{
    public float MaxHealth;

    [HideInInspector] public float currentHp;
    private void Start()
    {
        currentHp = MaxHealth;
    }

    public virtual void TakeDamage(float damage)
    {
        currentHp -= damage;
    }
}
