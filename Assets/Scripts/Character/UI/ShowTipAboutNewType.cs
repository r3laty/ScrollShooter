using System.Collections;
using UnityEngine;

public class ShowTipAboutNewType : MonoBehaviour
{
    [SerializeField] private BossHp bossHp;

    [SerializeField] private GameObject tipText;
    [SerializeField] private float tipDuration = 2;
    [Space]
    [SerializeField] private Item newType;
    private void OnEnable()
    {
        BossHp.BossDied += OnKilled;
    }
    private void OnDisable()
    {
        BossHp.BossDied -= OnKilled;
    }
    private void Update()
    {
        if (bossHp.BossKilled)
        {
            StartCoroutine(ShowTip());
        }
        else
        {
            StopCoroutine(ShowTip());
        }
    }
    private void OnKilled()
    {
        Inventory.AddItem(newType);
    }
    public IEnumerator ShowTip()
    {
        tipText.SetActive(true);
        yield return new WaitForSeconds(tipDuration);
        tipText.SetActive(false);
        bossHp.BossKilled = false;
    }
}
