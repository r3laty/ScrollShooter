using UnityEngine;

public class MakeShot : MonoBehaviour
{
    [HideInInspector] public bool FacingRight = true;
    [HideInInspector] public bool FacingLeft = false;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shotPoint;
    [SerializeField] private float bulletVelocity = 8;

    public void Shooting()
    {
        if (FacingRight)
        {
            GameObject magicBall = Instantiate(bullet, shotPoint.position, Quaternion.identity);
            magicBall.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletVelocity, ForceMode2D.Impulse);
        }
        else if (FacingLeft)
        {
            GameObject magicBall = Instantiate(bullet, shotPoint.position, Quaternion.identity);
            magicBall.transform.localScale = new Vector3(-2, 2, 2);
            magicBall.GetComponent<Rigidbody2D>().AddForce(-transform.right * bulletVelocity, ForceMode2D.Impulse);
        }
    }
}
