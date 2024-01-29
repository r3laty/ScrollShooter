using System.Collections;
using UnityEngine;
public class Phase1 : Boss
{
    public float AdditionalHp = 20;

    public static bool Reforged;

    [SerializeField] private float timeToFight = 8;
    [SerializeField] private float timeToNextAttack = 4;
    [Space]
    [SerializeField] private Animator spellAnim;

    private void Start()
    {
        StartCoroutine(StartOfFight());
    }
    public void BreakShield(float damage)
    {
        AdditionalHp -= damage;
        if (AdditionalHp == 0)
        {
            TurnAnimation(BossAnimator, "Hitted", true);
            Reforged = false;
        }
    }
    public void StopShieldAnimations()
    {
        TurnAnimation(BossAnimator, "Created", false);

        TurnAnimation(BossAnimator, "Hitted", false);
    }
    public void CastSpell()
    {
        spellAnim.gameObject.SetActive(true);

        TurnAnimation(spellAnim, "Cast", true);

        TurnAnimation(BossAnimator, "Casting", false);
    }
    private void MakeShield()
    {
        TurnAnimation(BossAnimator, "Created", true);
        Reforged = true;
    }

    private void SpellAttack()
    {
        TurnAnimation(BossAnimator, "Casting", true);
    }

    private IEnumerator StartOfFight()
    {
        yield return new WaitForSeconds(timeToFight);
        SpellAttack();
        yield return new WaitForSeconds(timeToNextAttack);
        MakeShield();
        while (true)
        {
            yield return new WaitForSeconds(timeToNextAttack);
            SpellAttack();
        }
    }

}
