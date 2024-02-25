using System.Collections;
using UnityEngine;

public class ShowTipAboutNewType : MonoBehaviour
{
    [SerializeField] private GameObject tipText;
    [SerializeField] private float tipDuration = 3;
    public IEnumerator ShowTip()
    {
        tipText.SetActive(true);
        yield return new WaitForSeconds(tipDuration);
        tipText.SetActive(false);
    }
}
