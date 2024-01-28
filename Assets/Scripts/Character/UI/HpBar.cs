using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private Die playerHealth;
    private void Update()
    {
        bar.fillAmount = playerHealth.currentHp / 100;
    }
}
