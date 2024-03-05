using UnityEngine;
using System.Collections;

public class SkeletonWizardAttack : MonoBehaviour
{
    [SerializeField] private GameObject rocket;
    [SerializeField] private float lifetime = 2;
    [SerializeField] private Transform shotPoint;
    [SerializeField] private float rocketVelocity = 5;
    [SerializeField] private float interval = 4;

    private Animator _evilAnim;
    private GameObject _newRocket;
    private bool _isIntervalEnded = true;
    private void Awake()
    {
        _evilAnim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (_isIntervalEnded)
        {
            _isIntervalEnded = false;
            _evilAnim.SetBool("Shoot", true);
        }
    }
    public IEnumerator ShootWithInterval()
    {
        _evilAnim.SetBool("Shoot", false);
        GameObject newRocket = Instantiate(rocket, shotPoint.position, Quaternion.identity);
        newRocket.GetComponent<Rigidbody2D>().AddForce(-transform.right * rocketVelocity, ForceMode2D.Impulse);

        yield return new WaitForSeconds(lifetime);
        Destroy(newRocket);

        yield return new WaitForSeconds(interval);
        _isIntervalEnded = true;
    }
}
