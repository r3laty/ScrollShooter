using UnityEngine;

public class MakeShot : MonoBehaviour
{
    [HideInInspector] public bool FacingRight = true;
    [HideInInspector] public bool FacingLeft = false;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shotPoint;

    public void Shooting()
    {
        if (FacingRight)
        {
            Instantiate(bullet, shotPoint.position, Quaternion.identity);
        }
        else if (FacingLeft)
        {
            GameObject magicBall = Instantiate(bullet, shotPoint.position, Quaternion.identity);
            magicBall.transform.localScale = new Vector3(-2, 2, 2);
        }
    }
}
