using UnityEngine;

public class MakeShot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shotPoint;
    public void Shooting()
    {
        Instantiate(bullet, shotPoint.position, Quaternion.identity);
    }
}
