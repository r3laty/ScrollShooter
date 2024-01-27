using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] private Die playerHp;
    [SerializeField] private GameObject tipText;

    [SerializeField] private float howMuchToHeal = 15;

    private bool _came;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _came = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(tipText);
            _came = false;
        }
    }
    private void Update()
    {
        if (_came)
        {
            tipText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                playerHp.currentHp = playerHp.currentHp + howMuchToHeal;
            }
            else if (Input.GetKeyUp(KeyCode.E))
            {
                tipText.SetActive(false);
            }
        }
    }
}
