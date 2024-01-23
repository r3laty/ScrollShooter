using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 3;
    [SerializeField] private float lifeTime = 1.5f;
    [SerializeField] private float damage = 5;
    [SerializeField] private float distanceOfRaycast = 0.8f;

    private Rigidbody2D _bollRb;
    private void Awake()
    {
        _bollRb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distanceOfRaycast);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                print("Hit enemy");
            }
        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        //if (Move.DirX > 0)
        //{
        //    _bollRb.AddForce(transform.right * speed, ForceMode2D.Impulse);
        //}
        //else if (Move.DirX < 0)
        //{
        //    _bollRb.AddForce(-transform.right * speed, ForceMode2D.Impulse);
        //}

    }
}
