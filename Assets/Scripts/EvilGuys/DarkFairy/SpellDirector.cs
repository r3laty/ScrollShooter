using UnityEngine;
[RequireComponent(typeof(Animator))]
public class SpellDirector : MonoBehaviour
{
    [SerializeField] private float damage = 25;

    private Animator _spellAnim;
    private Die _playerHp;
    private void Awake()
    {
        _playerHp = GetComponentInParent<Die>();
        _spellAnim = GetComponent<Animator>();
    }
    public void EndOfSpell()
    {
        _spellAnim.SetBool("Cast", false);
        this.gameObject.SetActive(false);
        _playerHp.currentHp -= damage;
    }
}
