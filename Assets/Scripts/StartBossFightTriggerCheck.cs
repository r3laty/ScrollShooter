using UnityEngine;

public class StartBossFightTriggerCheck : MonoBehaviour
{
    [SerializeField] private Phase1 bossController;
    [SerializeField] private GameObject bossSpell;
    [SerializeField] private GameObject bossHpBar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bossController.enabled = true;
            bossHpBar.SetActive(true);
        }
    }
}
