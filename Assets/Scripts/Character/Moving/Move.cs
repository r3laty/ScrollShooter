using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    [HideInInspector] public static float DirX;

    [SerializeField] private float scale = 3;

    [SerializeField] private float speed = 200;

    [SerializeField] private float dashingPower;

    private Rigidbody2D _rb;
    private MovementDirection _movementDirection;

    private bool _canDash;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _movementDirection = GetComponent<MovementDirection>();
    }

    private void Update()
    {
        DirX = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _canDash = true;
        }
    }

    private void FixedUpdate()
    {
        if (_canDash)
        {
            Vector2 dash = new Vector2(transform.localScale.x * dashingPower * Time.fixedDeltaTime, 0);
            transform.Translate(dash);
            _canDash = false;
        }
        else if(!_canDash)
        {
            Vector2 moving = new Vector2(DirX * speed * Time.fixedDeltaTime, _rb.velocity.y);
            _rb.velocity = moving;
        }

        _movementDirection.Flip(scale);
    }
    public void IncreeseDashPower(int multiplier)
    {
        dashingPower *= multiplier;
    }
}
