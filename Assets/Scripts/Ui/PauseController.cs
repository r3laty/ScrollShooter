using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private int menuSceneIndex;
    public void SetOnPause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void SetOffPause()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(menuSceneIndex);
    }
}
