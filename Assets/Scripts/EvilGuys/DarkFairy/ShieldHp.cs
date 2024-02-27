using UnityEngine;
using UnityEngine.UI;

public class ShieldHp : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private Phase1 shieldHp;

    [SerializeField] private float maxShieldHp;
    private void Start()
    {
        maxShieldHp = shieldHp.AdditionalHp;
    }
    private void Update()
    {
        if (Phase1.Reforged)
        {
            bar.gameObject.SetActive(true);
            bar.fillAmount = shieldHp.AdditionalHp / maxShieldHp;
            if (shieldHp.AdditionalHp < 0)
            {
                bar.gameObject.SetActive(false);
            }
        }
        else
        {
            bar.gameObject.SetActive(false);
        }
    }
}
