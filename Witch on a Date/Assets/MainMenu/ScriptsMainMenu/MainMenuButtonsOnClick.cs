using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonsOnClick : MonoBehaviour
{
    // This function opens the CreditsScene when the CREDITS button is clicked:
    public void openSettings()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); // Loads next scene with build number x+1
    }
}
