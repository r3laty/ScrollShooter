using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Jump : MonoBehaviour
{

    [SerializeField] private float jumpForce = 5;

    private CheckIsGrounded _isGrounded;
    private Rigidbody2D _rb;
    private void Awake()
    {
        _isGrounded = GetComponentInChildren<CheckIsGrounded>();
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (_isGrounded.isGrounded)
            {
                _rb.AddForce(Vector2.up * jumpForce);
            }
        }
    }
}
