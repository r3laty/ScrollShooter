using UnityEngine;

public class UpgradeCharacter : MonoBehaviour
{
    [SerializeField] private Lvl[] availableToUpgrade;

    [SerializeField] private CurrencyCollection currencyCollection;
    
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
