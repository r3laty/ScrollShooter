using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float lifeTime = 2;
    [SerializeField] private float damage = 5;
    [SerializeField] private float distanceOfRaycast = 0.8f;
    private void Start()
    {
        StartCoroutine(DestroyMagicBall());
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distanceOfRaycast);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Evil>().TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
    private IEnumerator DestroyMagicBall()
    {
        if (Attack.Attacked)
        {
            yield return new WaitForSeconds(lifeTime);
            Destroy(gameObject);
            Attack.Attacked = false;
        }
    }
}