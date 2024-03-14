using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    [SerializeField] private GameObject window;
    [SerializeField] private KeyCode keyToOpen;

    private bool _isOpen = false;
    private void Update()
    {
        if (!_isOpen && Input.GetKeyDown(keyToOpen))
        {
            window.SetActive(true);
            _isOpen = true;
        }

        else if (_isOpen && Input.GetKeyDown(keyToOpen))
        {
            window.SetActive(false);
            _isOpen = false;
        }
    }
}
