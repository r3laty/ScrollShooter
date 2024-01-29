using UnityEngine;
using UnityEngine.UI;

public class BossHpBar : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private Evil bossHp;

    private float _maxHp;
    private void Start()
    {
        _maxHp = bossHp.currentHp;
    }
    private void Update()
    {
        bar.fillAmount = bossHp.currentHp / _maxHp;
    }
}
