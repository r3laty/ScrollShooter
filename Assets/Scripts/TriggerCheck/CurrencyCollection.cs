using TMPro;
using UnityEngine;

public class CurrencyCollection : MonoBehaviour
{
    public int CurrencyCount;
    [Space]
    [SerializeField] private int howMuchCurrencyLoot;
    [Space]
    [SerializeField] private TextMeshProUGUI currencyCount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Currency"))
        {
            CurrencyCount += howMuchCurrencyLoot;
            UpdateCurrencyText();
            Destroy(collision.gameObject);
        }
    }
    public void UpdateCurrencyText()
    {
        currencyCount.text = CurrencyCount.ToString();
    }
}
