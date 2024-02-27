using System.Collections;
using UnityEngine;

public class ShowTipAboutNewType : MonoBehaviour
{
    [HideInInspector] public bool BossKilled;

    [SerializeField] private GameObject tipText;
    [SerializeField] private float tipDuration = 2;
    private void Update()
    {
        if (BossKilled)
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
        BossKilled = false;
    }
}
