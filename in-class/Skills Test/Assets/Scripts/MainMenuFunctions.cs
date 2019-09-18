using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFunctions : MonoBehaviour
{
    public GameObject loadingImage;
    public GameObject SettingScreen;

    public void PlayGame()
    {
        loadingImage.SetActive(false);
        Application.LoadLevel(1);
    }

    public void Settings()
    {
        if (SettingScreen.activeInHierarchy)
        {
            SettingScreen.SetActive(false);
        }

        else SettingScreen.SetActive(true);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
