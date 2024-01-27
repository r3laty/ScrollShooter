using UnityEngine;

public class EvilMagicBall : MonoBehaviour
{
    [SerializeField] private float damage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<Die>().TakeDamage(damage);
        }
    }
}
