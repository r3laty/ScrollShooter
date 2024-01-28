using UnityEngine;

public class Health : MonoBehaviour
{
    public static bool Dead;

    public float currentHp;
    private void Start()
    {
        Dead = false;
    }

    public virtual void TakeDamage(float damage)
    {
        currentHp -= damage;
        Dead = true;
    }
}
