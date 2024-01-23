using UnityEngine;
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Move))]
public class Animations : MonoBehaviour
{
    private Move _controller;
    private Animator _animator;

    private AnimatorControllerParameter[] _animator_parametres;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _controller = GetComponent<Move>();
        _animator_parametres = _animator.parameters;
    }
    private void Update()
    {
        if (Move.DirX > 0)
        {
            _animator.SetBool("IsMoving", true);
        }
        if (Move.DirX < 0)
        {
            _animator.SetBool("IsMoving", true);
        }
        if (Move.DirX == 0)
        {
            foreach (AnimatorControllerParameter parameter in _animator_parametres)   //Disable all animations
            {
                if (parameter.type == AnimatorControllerParameterType.Bool)
                {
                    _animator.SetBool(parameter.name, false);
                }
            }
        }
    }
}
