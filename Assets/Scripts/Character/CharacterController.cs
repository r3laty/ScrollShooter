using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController : MonoBehaviour
{
    [HideInInspector] public float DirX;
    
    [SerializeField] private float scale = 4;

    [SerializeField] private float speed = 5;

    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        DirX = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector2 moving = new Vector2(DirX * speed * Time.fixedDeltaTime, _rb.velocity.y);
        _rb.velocity = moving;
        Flip();
    }
    private void Flip()
    {
        if (DirX > 0)
        {
            transform.localScale = new Vector3(scale, scale, 0);
        }
        else if (DirX < 0)
        {
            transform.localScale = new Vector3(-scale, scale, 0);
        }
    }
}
