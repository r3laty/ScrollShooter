using UnityEngine;

public class Evil : MonoBehaviour
{
    public float Health;

    private float _currentHp;
    private void Start()
    {
        _currentHp = Health;
    }

    public void TakeDamage(float damage)
    {
        _currentHp -= damage;
        if (_currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
