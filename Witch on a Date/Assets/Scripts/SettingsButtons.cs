using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButtons : MonoBehaviour
{
    // Променлива в която сухранявам дали играта е със спрян звук
    public static bool mute = false;

    // Отваря сцената MainMenu, когато бутонът RETURN е натиснат:
    public void openMainMenu()
    {
        Buttons.mute = mute;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // Loads next scene with build number x-1
    }

    // Спира всякакъв звук в играта, когато бутонът MUTE е натиснат и го връща, когато UNMUTE е натиснат:
    public void muteGame()
    {
            mute = !mute;
    }

}
