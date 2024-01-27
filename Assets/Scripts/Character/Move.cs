using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    [HideInInspector] public static float DirX;
    
    [SerializeField] private float scale = 4;

    [SerializeField] private float speed = 5;

    private MakeShot _shot;
    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _shot = GetComponent<MakeShot>();
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
            _shot.FacingRight = true;
            _shot.FacingLeft = false;
        }
        else if (DirX < 0)
        {
            transform.localScale = new Vector3(-scale, scale, 0);
            _shot.FacingRight = false;
            _shot.FacingLeft = true;
        }
    }
}
