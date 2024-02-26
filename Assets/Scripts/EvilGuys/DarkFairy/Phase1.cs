using System.Collections;
using UnityEngine;
public class Phase1 : MonoBehaviour
{
    public float AdditionalHp = 20;

    public static bool Reforged;

    [SerializeField] private Animator bossAnim;
    [Space]
    [SerializeField] private float timeToFight = 8;
    [SerializeField] private float timeToNextAttack = 4;
    [Space]
    [SerializeField] private SpellDirector spellDirector;
    [SerializeField] private Animator spellAnim;

    private void Start()
    {
        StartCoroutine(StartOfBossFight());
    }
    private void Update()
    {
        
    }
    public void BreakShield(float damage)
    {
        AdditionalHp -= damage;
        Debug.Log(AdditionalHp + " Addition hp");

        if (AdditionalHp <= 0)
        {
            StopShieldAnimations();
            Reforged = false;
        }
    }
    public void SpellAtttack()
    {
        spellDirector.IsSpellAttack = true;

        bossAnim.SetBool("Casting", false);

        spellAnim.SetBool("Cast", true);
    }
    public void BackToIdle()
    {
        bossAnim.SetBool("Hitted", false);
    }
    private void StopShieldAnimations()
    {
        bossAnim.SetBool("Created", false);
        bossAnim.SetBool("Hitted", true);
    }
    private void MakeShield()
    {
        bossAnim.SetBool("Created", true);
        Reforged = true;
    }

    private void CastingSpell()
    {
        bossAnim.SetBool("Casting", true);
    }

    private IEnumerator StartOfBossFight()
    {
        yield return new WaitForSeconds(timeToFight);
        CastingSpell();
        yield return new WaitForSeconds(timeToNextAttack);
        MakeShield();
        while (true)
        {
            yield return new WaitForSeconds(timeToNextAttack);
            CastingSpell();
        }
    }

}
