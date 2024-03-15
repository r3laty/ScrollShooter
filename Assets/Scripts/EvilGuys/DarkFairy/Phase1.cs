using System.Collections;
using UnityEngine;
public class Phase1 : MonoBehaviour
{
    public float AdditionalHp = 20;

    public static bool Reforged;

    [SerializeField] protected Animator bossAnim;
    [Space]
    [SerializeField] protected float timeToFight = 8;
    [SerializeField] protected float timeToNextAttack = 4;
    [Space]
    [SerializeField] protected SpellDirector spellDirector;
    [SerializeField] protected Animator spellAnim;
    [Space] 
    [SerializeField] protected int prizeForKill = 2;
    [SerializeField] protected CurrencyCollection currencyCollection;

    private BossHp bossHp;

    private void Awake()
    {
        bossHp = GetComponent<BossHp>();
    }
    private void Start()
    {
        StartCoroutine(StartOfBossFight());
    }
    private void OnEnable()
    {
        BossHp.BossDied += Die;
    }
    public void BreakShield(float damage)
    {
        AdditionalHp -= damage;

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

        spellAnim.SetBool("Cast_phase1", true);
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

    private void Die()
    {
        currencyCollection.CurrencyCount += prizeForKill;
        currencyCollection.UpdateCurrencyText();
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
    private void OnDisable()
    {
        BossHp.BossDied -= Die;
    }

}
