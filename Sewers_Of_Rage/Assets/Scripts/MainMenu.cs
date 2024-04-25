using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject startButton;
    public GameObject settingsButton;
    public GameObject exitButton; 
    public GameObject backButton;
    public GameObject title;

    public void StartButton()
    {
        SceneManager.LoadScene(+1);
    }

    public void SettingsButton()
    {
        if (startButton.activeInHierarchy == true)
        {
            startButton.SetActive(false);
        }
        if (settingsButton.activeInHierarchy == true)
        {
            settingsButton.SetActive(false);
        }
        if (exitButton.activeInHierarchy == true)
        {
            exitButton.SetActive(false);
        }
        if (backButton.activeInHierarchy == false)
        {
            backButton.SetActive(true);
        }
        if (title.activeInHierarchy == true)
        {
            title.SetActive(false);
        }
    }

    public void BackButton()
    {
        if (startButton.activeInHierarchy == false)
        {
            startButton.SetActive(true);
        }
        if (settingsButton.activeInHierarchy == false)
        {
            settingsButton.SetActive(true);
        }
        if (exitButton.activeInHierarchy == false)
        {
            exitButton.SetActive(true);
        }
        if (backButton.activeInHierarchy == true)
        {
            backButton.SetActive(false);
        }
        if (title.activeInHierarchy == false)
        {
            title.SetActive(true);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
