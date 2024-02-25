using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    [HideInInspector] public static float DirX;
    
    [SerializeField] private float scale = 3;

    [SerializeField] private float speed = 200;

    private Rigidbody2D _rb;
    private MovementDirection _movementDirection;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _movementDirection = GetComponent<MovementDirection>();
    }

    private void Update()
    {
        DirX = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector2 moving = new Vector2(DirX * speed * Time.fixedDeltaTime, _rb.velocity.y);
        _rb.velocity = moving;
        _movementDirection.Flip(scale);
    }
}
