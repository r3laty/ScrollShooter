using UnityEngine;

public class Health : MonoBehaviour
{
    public float MaxHealth;

    protected float _currentHp;
    private void Start()
    {
        _currentHp = MaxHealth;
    }

    public virtual void TakeDamage(float damage)
    {
        _currentHp -= damage;

        Debug.Log(_currentHp + " hp");
    }
}
