using UnityEngine;
using System.Collections;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private GameObject rocket;
    [SerializeField] private float lifetime;
    [SerializeField] private Transform shotPoint;
    [SerializeField] private float rocketVelocity = 8;
    [SerializeField] private float interval;
    private void Start()
    {
        StartCoroutine(ShootWithInterval());
    }
    private IEnumerator ShootWithInterval()
    {
        while (true)
        {
            GameObject newRocket = Instantiate(rocket, shotPoint.position, Quaternion.identity);
            newRocket.GetComponent<Rigidbody2D>().AddForce(-transform.right * rocketVelocity, ForceMode2D.Impulse);
            yield return new WaitForSeconds(lifetime);
            Destroy(newRocket);
        }
    }

}
