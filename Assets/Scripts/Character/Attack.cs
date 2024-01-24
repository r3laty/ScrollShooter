 using UnityEngine;
public class Attack : MonoBehaviour
{
    public static bool Attacked;

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
            Attacked = true;
        }
    }
}
