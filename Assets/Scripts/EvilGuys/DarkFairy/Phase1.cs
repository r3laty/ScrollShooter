using System.Collections;
using UnityEngine;
public class Phase1 : Boss
{
    [HideInInspector] public float AdditionalHp = 20;

    public static bool Reforged;

    [SerializeField] private Evil bossHp;
    [SerializeField] private float timeToShield = 8;
    private void Start()
    {
        StartCoroutine(MakingShield());
    }
    public void BreakShield(float damage)
    {
        AdditionalHp -= damage;
        if (AdditionalHp == 0)
        {
            TurnAnimationOn(BossAnimator, "Hitted", true);
            Reforged = false;
        }
    }
    public void StopAnimation()
    {
        TurnAnimationOn(BossAnimator, "Created", false);

        TurnAnimationOn(BossAnimator, "Hitted", false);
    }
    private void MakeShield()
    {
        TurnAnimationOn(BossAnimator, "Created", true);
        Reforged = true;
    }

    private IEnumerator MakingShield()
    {
        yield return new WaitForSeconds(timeToShield);
        MakeShield();
    }
    
}
