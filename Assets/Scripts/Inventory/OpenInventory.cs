using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    [SerializeField] private GameObject inventary;
    private bool _isOpen = false;
    private void Update()
    {
        if (!_isOpen && Input.GetKeyDown(KeyCode.I))
        {
            inventary.SetActive(true);
            _isOpen = true;
        }

        else if (_isOpen && Input.GetKeyDown(KeyCode.I))
        {
            inventary.SetActive(false);
            _isOpen = false;
        }
    }
}
