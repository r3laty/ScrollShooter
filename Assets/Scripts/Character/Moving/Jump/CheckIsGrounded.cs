using UnityEngine;

public class CheckIsGrounded : MonoBehaviour
{
    [HideInInspector] public bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsGroundedUpdate(collision, true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsGroundedUpdate(collision, false);
    }

    private void IsGroundedUpdate(Collider2D collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            isGrounded = value;
        }
    }
}
