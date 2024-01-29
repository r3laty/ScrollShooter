using UnityEngine;

public class EndBossFightTriggerCheck : MonoBehaviour
{
    [SerializeField] private GameObject bossHpBar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bossHpBar.SetActive(false);
        }
    }
}
