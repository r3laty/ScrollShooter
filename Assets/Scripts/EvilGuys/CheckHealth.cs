using UnityEngine;

public class CheckHealth : MonoBehaviour
{
    [SerializeField] private GameObject winMenu;
    [SerializeField] private BossHp bossHp;

    private void Update()
    {
        if (bossHp.BossKilled)
        {
            winMenu.SetActive(true);
        }
    }
}
