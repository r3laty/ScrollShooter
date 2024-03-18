using UnityEngine;

public class UpgradeCharacter : MonoBehaviour
{
    [SerializeField] private Lvl[] availableToUpgrade;
    [SerializeField] private int dashMultiplayer = 2;

    [SerializeField] private CurrencyCollection currencyCollection;
    [SerializeField] private Move move;
    private int _currentUpgrade = 0;
    private void Update()
    {
        print(currencyCollection.CurrencyCount + " currency count");
    }
    public void OnClick()
    {
        var Lvl = availableToUpgrade[_currentUpgrade];
        if (Lvl.CurrentPrice <= currencyCollection.CurrencyCount)
        {
            Lvl.LvlIcon.SetActive(true);
            currencyCollection.CurrencyCount -= Lvl.CurrentPrice;
            currencyCollection.UpdateCurrencyText();
            move.IncreeseDashPower(dashMultiplayer);
            Lvl.NextPrice.SetActive(true);
            _currentUpgrade++;
        }
        else
        {
            print("Not enought money\n" +
                "Play sound");
        }

    }
}
