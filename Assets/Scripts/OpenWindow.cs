using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    [SerializeField] private GameObject window;
    [SerializeField] private KeyCode keyToOpen;
    [SerializeField] private GameObject currencyCountWindow; 

    private bool _isOpen = false;
    private void Update()
    {
        if (!_isOpen && Input.GetKeyDown(keyToOpen))
        {
            window.SetActive(true);
            currencyCountWindow.SetActive(false);
            _isOpen = true;
        }

        else if (_isOpen && Input.GetKeyDown(keyToOpen))
        {
            window.SetActive(false);
            currencyCountWindow.SetActive(true);
            _isOpen = false;
        }
    }
}
