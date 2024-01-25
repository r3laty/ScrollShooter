using UnityEngine;

public class Boss : MonoBehaviour
{
    public Animator BossAnimator;
    public virtual void TurnAnimationOn(Animator animator, string parametrName, bool conditional)
    {
        animator.SetBool(parametrName, conditional);
    }
}
