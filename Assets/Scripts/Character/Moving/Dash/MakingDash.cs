using System.Collections;
using UnityEngine;

public class MakingDash : MonoBehaviour
{
    [SerializeField] private float dashingPower = 5;


    private Collider2D _collider;
    private Animator _anim;
    private Rigidbody2D _rb;

    private bool _canDash = true;
    private bool _isDashing;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _collider = GetComponent<Collider2D>();
    }
}
