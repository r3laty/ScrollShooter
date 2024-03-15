using System.Collections;
using UnityEngine;

public class Phase2 : Phase1
{
    [Space]
    [SerializeField] private float explosionRadius = 3;
    [SerializeField] private float explosionDamage = 45;
    private void OnEnable()
    {
        BossHp.BossDied += Die; 
    }
    private void Start()
    {
        StartCoroutine(StartOfBossFight());
    }
    public new void SpellAtttack()
    {
        spellDirector.IsSpellAttack = true;

        bossAnim.SetBool("Casting", false);

        spellAnim.SetBool("Cast_phase2", true);
    }
    public new void BackToIdle()
    {
        bossAnim.SetBool("Explode", false);
    }
    public void DamageOfExplosion()
    {
        Collider2D[] overlappedColliders = Physics2D.OverlapCircleAll(transform.position, explosionRadius);

        foreach (Collider2D collider in overlappedColliders)
        {
            CharacterHp characterHp = collider.GetComponent<CharacterHp>();
            if (characterHp != null)
            {
                characterHp.TakeDamage(explosionDamage);
                Debug.Log(characterHp.name + " character hp found");
            }
        }
    }

    private void CastingSpell()
    {
        bossAnim.SetBool("Casting", true);
    }
    private void Explode()
    {
        bossAnim.SetBool("Explode", true);
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
        while (true)
        {
            yield return new WaitForSeconds(timeToNextAttack);
            CastingSpell();
            yield return new WaitForSeconds(timeToNextAttack);
            Explode();
        }
    }
    private void OnDisable()
    {
        BossHp.BossDied -= Die;
    }

}
