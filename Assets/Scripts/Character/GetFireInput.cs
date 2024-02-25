using UnityEngine;
public class GetFireInput : MonoBehaviour
{
    public static bool SphereAttacked;
    public static bool BowAttacked;

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
        
        if (BossHp.KilledBoss && Input.GetButtonDown("Fire2"))
        {
            BowAttacked = true;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            BowAttacked = false;
        }
    }
}
