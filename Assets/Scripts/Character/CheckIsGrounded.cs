using UnityEngine;

public class CheckIsGrounded : MonoBehaviour
{
    [HideInInspector] public bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsGroundedUpate(collision, true);
        print(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsGroundedUpate(collision, false);
    }

    private void IsGroundedUpate(Collider2D collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            isGrounded = value;
        }
    }
}
