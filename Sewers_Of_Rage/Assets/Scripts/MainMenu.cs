using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingMenu;
    public GameObject gameplayMenu;
    public GameObject audioMenu;

    public void StartButton()
    {
        SceneManager.LoadScene(+1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void SettingsBackButton()
    {
        if (mainMenu.activeInHierarchy == false)
        {
            mainMenu.SetActive(true);
        }
        if (settingMenu.activeInHierarchy == true)
        {
            settingMenu.SetActive(false);
        }
    }
    
    public void AudioBackButton()
    {
        if (settingMenu.activeInHierarchy == false)
        {
            settingMenu.SetActive(true);
        }
        if (audioMenu.activeInHierarchy == true)
        {
            audioMenu.SetActive(false);
        }
    }

    public void GameplayBackButton()
    {
        if (settingMenu.activeInHierarchy == false)
        {
            settingMenu.SetActive(true);
        }
        if (gameplayMenu.activeInHierarchy == true)
        {
            gameplayMenu.SetActive(false);
        }
    }

    public void SettingsButton()
    {
        if (mainMenu.activeInHierarchy == true)
        {
            mainMenu.SetActive(false);
        }
        if (settingMenu.activeInHierarchy == false)
        {
            settingMenu.SetActive(true);
        }
    }
    
    public void GameplayButton()
    {
        if (settingMenu.activeInHierarchy == true)
        {
            settingMenu.SetActive(false);
        }
        if (gameplayMenu.activeInHierarchy == false)
        {
            gameplayMenu.SetActive(true);
        }
    }

    public void AudioButton() 
    {
        if (settingMenu.activeInHierarchy == true)
        {
            settingMenu.SetActive(false);
        }
        if (audioMenu.activeInHierarchy == false)
        {
            audioMenu.SetActive(true);
        }
    }
}
