using UnityEngine;
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CharacterController))]
public class Animations : MonoBehaviour
{
    private CharacterController _controller;
    private Animator _animator;

    private AnimatorControllerParameter[] _animator_parametres;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _controller = GetComponent<CharacterController>();
        _animator_parametres = _animator.parameters;
    }
    private void Update()
    {
        if (_controller.DirX > 0)
        {
            _animator.SetBool("IsMoving", true);
        }
        if (_controller.DirX < 0)
        {
            _animator.SetBool("IsMoving", true);
        }
        if (_controller.DirX == 0)
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
