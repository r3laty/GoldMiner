using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject settingsMenu;
    public void OnSettingsClick()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void OnExitClick()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void OnPlayButtonClick()
    {
        mainMenu.SetActive(false);
    }
}
