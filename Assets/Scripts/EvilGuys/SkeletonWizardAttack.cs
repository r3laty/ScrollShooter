using UnityEngine;
using System.Collections;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private GameObject rocket;
    [SerializeField] private float lifetime = 2;
    [SerializeField] private Transform shotPoint;
    [SerializeField] private float rocketVelocity = 5;
    [SerializeField] private float interval = 4;
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
            yield return new WaitForSeconds(interval);
        }
    }

}
