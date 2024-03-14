using UnityEngine;

public class UpgradeCharacter : MonoBehaviour
{
    [SerializeField] private Lvl[] availableToUpgrade;

    [SerializeField ] private float _currentMoney = 1;
    private int _currentUpgrade = 0;

    public void OnClick()
    {
        var Lvl = availableToUpgrade[_currentUpgrade];
        if (Lvl.CurrentPrice <= _currentMoney)
        {
            Lvl.LvlIcon.SetActive(true);
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
