using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void GotoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("BossFight 1");
    }
    public void GoToCharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");
    }
    public void GoToSettings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
    public void GoToExit()
    {
        Application.Quit();
    }

}
