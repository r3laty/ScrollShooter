 using UnityEngine;
public class Attack : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    private MakeShot _shot;
    private void Awake()
    {
        _shot = GetComponent<MakeShot>();
    }
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("IsSphereAttack", true);
            
        }
        //else if (Input.GetButtonUp("Fire1"))
        //{
        //    animator.SetBool("IsSphereAttack", false);
        //}

    }
}
