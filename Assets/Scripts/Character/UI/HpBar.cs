using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private CharacterHp playerHealth;

    private float _maxHp;
    private void Start()
    {
        _maxHp = playerHealth.CurrentHp;
    }
    private void Update()
    {
        bar.fillAmount = playerHealth.CurrentHp / _maxHp;
    }
}
