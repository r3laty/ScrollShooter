using UnityEngine;
public class Attack : MonoBehaviour
{
    public static bool Attacked;

    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _animator.SetBool("IsSphereAttack", true);
            Attacked = true;
        }
    }
}
