using UnityEngine;
using UnityEngine.UI;

public class ShieldHp : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private Phase1 shieldHp;

    private float _maxHp;
    private void Start()
    {
        _maxHp = shieldHp.AdditionalHp;
    }
    private void Update()
    {
        bar.fillAmount = shieldHp.AdditionalHp / _maxHp;

        if (shieldHp.AdditionalHp <= 0)
        {
            bar.gameObject.SetActive(false);
        }
    }
}
