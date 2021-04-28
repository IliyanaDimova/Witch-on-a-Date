using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // This function opens the SettingsScene when the SETTINGS button is clicked:
    public void openSettings()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads next scene with build number x+1
    }

    // This function opens the playable game when the PLAY button is clicked:
    public void openPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); // Loads next scene with build number x+2
    }

    // This function opens the MainMenu when RETURN button is pressed:
    public void openMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // Loads next scene with build number x-1
    }
}