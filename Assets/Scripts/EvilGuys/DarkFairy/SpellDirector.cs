using Unity.VisualScripting;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class SpellDirector : MonoBehaviour
{
    [HideInInspector] public bool IsSpellAttack;

    [SerializeField] private float damage = 25;

    [SerializeField] private Phase PhaseOfBoss;

    private Animator _spellAnim;
    private CharacterHp _playerHp;
    private Transform _player;
    private void Awake()
    {
        _playerHp = GetComponentInParent<CharacterHp>();
        _spellAnim = GetComponent<Animator>();
        _player = _playerHp.GetComponent<Transform>();
    }
    private void Update()
    {
        if (!IsSpellAttack)
        {
            gameObject.transform.position = _player.position;
            gameObject.transform.SetParent(_player);
        }

        if (IsSpellAttack)
        {
            gameObject.transform.SetParent(null);
        }
    }
    public void EndOfSpell()
    {
        IsSpellAttack = false;
        if (PhaseOfBoss == Phase.First)
        {
            _spellAnim.SetBool("Cast_phase1", false);
        }
        else if (PhaseOfBoss == Phase.Second)
        {
            _spellAnim.SetBool("Cast_phase2", false);
        }

        RaycastHit2D hit;
        Vector2 direction = -transform.up;
        float distance = 0.5f;

        hit = Physics2D.Raycast(transform.position, direction, distance);

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Player"))
            {
                _playerHp.currentHp -= damage;
            }
        }
    }
}
enum Phase
{
    First,
    Second
}
