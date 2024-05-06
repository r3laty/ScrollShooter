using UnityEngine;
using UnityEngine.UI;

public class BossHpBar : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private BossHp bossHp;

    private float _maxHp;
    private void Start()
    {
        _maxHp = bossHp.CurrentHp;
    }
    private void Update()
    {
        bar.fillAmount = bossHp.CurrentHp / _maxHp;

        if (bossHp.CurrentHp <= 0)
        {
            bar.gameObject.SetActive(false);
        }
    }
}
