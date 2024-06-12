using System;
using UnityEngine;
using FMODUnity;

public class Healing : MonoBehaviour
{
    public static Action Healed;

    [SerializeField] private CharacterHp playerHp;
    [SerializeField] private GameObject tipText;
    [Space]
    [SerializeField] private EventReference healingSound;

    [SerializeField] private int howMuchToHeal = 15;

    private bool _came;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tipText.SetActive(true);
            _came = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tipText.SetActive(false);
            _came = false;
        }
    }
    private void Update()
    {
        DoHealing();
    }
    private void DoHealing()
    {
        if (_came)
        {
            if (Input.GetKeyDown(KeyCode.E) && tipText)
            {
                MusicController.Instance.PlayOneShot(healingSound, transform.position);
                playerHp.Heal(howMuchToHeal);
            }
            else if (Input.GetKeyUp(KeyCode.E))
            {
                Destroy(tipText);
                Destroy(gameObject);
            }
        }
    }
}
