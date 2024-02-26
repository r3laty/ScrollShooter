using UnityEngine;
public class GetFireInput : MonoBehaviour
{
    public static bool SphereAttacked;
    public static bool BowAttacked;

    [SerializeField] private BossHp bossHp;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SphereAttacked = true;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            SphereAttacked = false;
        }
        
        if (bossHp.currentHp <= 0 && Input.GetButtonDown("Fire2"))
        {
            BowAttacked = true;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            BowAttacked = false;
        }
    }
}
