using System;
using UnityEngine;

public class BossFightTriggerCheck : MonoBehaviour
{
    public static event Action EnteredToBossArea;

    [SerializeField] private Phase1 bossController;
    [SerializeField] private GameObject bossSpell;
    [SerializeField] private GameObject bossHpBar;
    private void OnEnable()
    {
        BossHp.BossDied += OnDied;
    }
    private void OnDisable()
    {
        BossHp.BossDied -= OnDied;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bossSpell.SetActive(true);
            bossController.enabled = true;
            bossHpBar.SetActive(true);

            EnteredToBossArea?.Invoke();
        }
    }

    private void OnDied()
    {
        bossSpell.SetActive(false);
    }

}
