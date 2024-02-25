using System.Collections;
using UnityEngine;

public class MakeShot : MonoBehaviour
{
    [HideInInspector] public bool FacingRight = true;
    [HideInInspector] public bool FacingLeft = false;

    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject arrow;
    [SerializeField] private Transform shotPoint;
    [SerializeField] private float bulletVelocity = 8;

    private float _sphereSizeX;
    private float _arrowSizeX;

    private bool _bowAttacked;
    private bool _sphereAttacked;
    private void Awake()
    {
        _sphereSizeX = sphere.transform.localScale.x;
        _arrowSizeX = arrow.transform.localScale.x;
    }

    private void Update()
    {
        if (GetFireInput.SphereAttacked)
        {
            _sphereAttacked = true;
        }
        else if (GetFireInput.BowAttacked)
        {
            _bowAttacked = true;
        }
    }
    public void Shooting()
    {
        if (FacingRight)
        {
            if (_sphereAttacked)
            {
                GameObject magicBall = Instantiate(sphere, shotPoint.position, Quaternion.identity);
                magicBall.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletVelocity, ForceMode2D.Impulse);
                _sphereAttacked = false;
            }

            if (_bowAttacked)
            {
                GameObject magicBow = Instantiate(arrow, shotPoint.position, Quaternion.identity);
                magicBow.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletVelocity, ForceMode2D.Impulse);
                _bowAttacked = false;
            }
        }
        else if (FacingLeft)
        {
            if (_sphereAttacked)
            {
                GameObject magicBall = Instantiate(sphere, shotPoint.position, Quaternion.identity);
                magicBall.transform.localScale = new Vector3(-_sphereSizeX, _sphereSizeX, _sphereSizeX);
                magicBall.GetComponent<Rigidbody2D>().AddForce(-transform.right * bulletVelocity, ForceMode2D.Impulse);
            }

            if(_bowAttacked)
            {
                GameObject magicBow = Instantiate(arrow, shotPoint.position, Quaternion.identity);
                magicBow.transform.localScale = new Vector3(-_arrowSizeX, _arrowSizeX, _arrowSizeX);
                magicBow.GetComponent<Rigidbody2D>().AddForce(-transform.right * bulletVelocity, ForceMode2D.Impulse);
            }
        }
    }
}
