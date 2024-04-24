using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject inGameUIMenu;
    [SerializeField] private GameObject winMenu;
    [SerializeField] private GameObject pauseMenu;

    private int _activeSceneBuildIndex;
    private void Awake()
    {
        _activeSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void OnSettingsClick()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void OnExitClick()
    {
        settingsMenu.SetActive(false);
        winMenu.SetActive(false);
        pauseMenu.SetActive(false);

        mainMenu.SetActive(true);
    }
    public void OnPlayButtonClick()
    {
        mainMenu.SetActive(false);
        inGameUIMenu.SetActive(true);
    }
    public void OnPauseClick()
    {
        pauseMenu.SetActive(true);
        inGameUIMenu.SetActive(false);
    }
    public void OnPauseLeaveClick()
    {
        pauseMenu.SetActive(false);
        inGameUIMenu.SetActive(true);
    }
    public void OnRetryClick()
    {
        SceneManager.LoadScene(_activeSceneBuildIndex);
    }
}
