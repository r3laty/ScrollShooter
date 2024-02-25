using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHp;

    public virtual void TakeDamage(float damage)
    {
        currentHp -= damage;
    }
}
