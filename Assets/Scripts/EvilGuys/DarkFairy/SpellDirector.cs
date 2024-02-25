using UnityEngine;
[RequireComponent(typeof(Animator))]
public class SpellDirector : MonoBehaviour
{
    [SerializeField] private float damage = 25;

    private Animator _spellAnim;
    private CharacterHp _playerHp;
    private void Awake()
    {
        _playerHp = GetComponentInParent<CharacterHp>();
        _spellAnim = GetComponent<Animator>();
    }
    public void EndOfSpell()
    {
        _spellAnim.SetBool("Cast", false);
        gameObject.SetActive(false);
        _playerHp.currentHp -= damage;
    }
}
