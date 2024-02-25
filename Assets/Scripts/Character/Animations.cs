using UnityEngine;
[RequireComponent(typeof(Animator))]
public class Animations : MonoBehaviour
{
    private Animator _animator;

    private AnimatorControllerParameter[] _animator_parametres;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Move.DirX > 0)
        {
            _animator.SetBool("IsMoving", true); 
        }

        else if (Move.DirX < 0)
        {
            _animator.SetBool("IsMoving", true);
        }

        else if (Move.DirX == 0)
        {
            _animator.SetBool("IsMoving", false);
        }

        if (GetFireInput.SphereAttacked)
        {
            _animator.SetBool("IsSphereAttack", true);
        }
        else if (!GetFireInput.SphereAttacked)
        {
            _animator.SetBool("IsSphereAttack", false);
        }

        if (GetFireInput.BowAttacked)
        {
            _animator.SetBool("IsMagicBowAttack", true);
        }
        else if (!GetFireInput.BowAttacked)
        {
            _animator.SetBool("IsMagicBowAttack", false);
        }
    }
}
