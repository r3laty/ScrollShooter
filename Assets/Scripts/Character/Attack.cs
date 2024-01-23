 using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("IsSphereAttack", true);
            print("fire");
        }
        //else if (Input.GetButtonUp("Fire1"))
        //{
        //    animator.SetBool("IsSphereAttack", false);
        //}

    }
}
