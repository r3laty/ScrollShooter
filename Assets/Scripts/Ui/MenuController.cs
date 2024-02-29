using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject aboutAuthorMenu;
    [Space]
    [SerializeField] private int gameSceneIndex;
    public void OpenAboutAuthorMenu()
    {
        aboutAuthorMenu.SetActive(true);
    }
    public void CloseAboutAuthorMenu()
    {
        aboutAuthorMenu.SetActive(false);
    }
    public void StartNewGame()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }
    public void LeaveFromGame()
    {
        Application.Quit(); 
    }
}
