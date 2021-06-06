using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Променлива в която сухранявам дали играта е със спрян звук
    public static bool mute;

    // Отваря сцената SettingsScene, когато бутонът SETTINGS е натиснат:
    public void openSettings()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads next scene with build number x+1
    }

    // Отваря сцената PlayScene, когато бутонът PLAY е натиснат:
    public void openPlay()
    {
        Sound.mute = mute;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); // Loads next scene with build number x+2
    }

}