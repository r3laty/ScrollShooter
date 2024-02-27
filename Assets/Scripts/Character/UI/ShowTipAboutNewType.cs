using System.Collections;
using UnityEngine;

public class ShowTipAboutNewType : MonoBehaviour
{
    [SerializeField] private BossHp bossHp;

    [SerializeField] private GameObject tipText;
    [SerializeField] private float tipDuration = 2;

    private bool _killed;
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
    public IEnumerator ShowTip()
    {
        tipText.SetActive(true);
        yield return new WaitForSeconds(tipDuration);
        print("tip corutine working!");
        tipText.SetActive(false);
        bossHp.BossKilled = false;
    }
}
