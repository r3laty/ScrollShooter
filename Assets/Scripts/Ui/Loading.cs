using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] private float loadingTime;
    [SerializeField] private int gameSceneIndex;

    private void Start()
    {
        StartCoroutine(LoadLevel());
    }
    private IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(loadingTime);
        gameObject.SetActive(false);
        SceneManager.LoadScene(gameSceneIndex);
    }
}
