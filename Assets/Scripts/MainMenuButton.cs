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
        SceneManager.LoadScene("BossFight");
    }
    public void GoToCharacterSelect()
    {
        SceneManager.LoadScene("CharactersSelect");
    }
    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void GoToExit()
    {
        Application.Quit();
    }

}
