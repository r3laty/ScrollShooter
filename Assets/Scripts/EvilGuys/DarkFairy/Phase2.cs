using System.Collections;
using UnityEngine;

public class Phase2 : Phase1
{
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
    private void CastingSpell()
    {
        bossAnim.SetBool("Casting", true);
    }
    private IEnumerator StartOfBossFight()
    {
        yield return new WaitForSeconds(timeToFight);
        CastingSpell();
        while (true)
        {
            yield return new WaitForSeconds(timeToNextAttack);
            CastingSpell();
        }
    }


}
