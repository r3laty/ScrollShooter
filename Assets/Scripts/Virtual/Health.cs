using UnityEngine;

public class Health : MonoBehaviour
{
    public float CurrentHp;

    public virtual void TakeDamage(float damage)
    {
        CurrentHp -= damage;
    }
}
