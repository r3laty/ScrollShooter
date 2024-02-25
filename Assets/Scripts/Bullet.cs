using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage = 5;
    [SerializeField] private float distanceOfRaycast = 0.8f;
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distanceOfRaycast);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Evil>().TakeDamage(damage);
            }
            if (hitInfo.collider.CompareTag("Boss_phase1"))
            {
                if (Phase1.Reforged)
                {
                    hitInfo.collider.GetComponent<Phase1>().BreakShield(damage);
                }
                hitInfo.collider.GetComponent<BossHp>().TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}