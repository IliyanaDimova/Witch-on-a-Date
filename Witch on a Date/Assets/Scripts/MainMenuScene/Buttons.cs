using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Buttons : MonoBehaviour
{
    // Променлива в която сухранявам дали играта е със спрян звук
    public static bool mute = false;
    // Текста на Mute бутона
    public TextMeshProUGUI changeText;

    // Start is called before the first frame update
    void Start()
    {
        if (mute)
        {
            // Смени текста на бутона на UNMUTE
            changeText.text = "UNMUTE";
        }
        else
        {
            changeText.text = "MUTE";
        }
    }

    // Спира звука на играта
    public void muteGame()
    {
        // Ако звука е спрян
        if (mute)
        {
            // Смени текста на бутона на MUTE
            changeText.text = "MUTE";
        }
        else
        {
            // Смени текста на бутона на UNMUTE
            changeText.text = "UNMUTE";
        }
        // Смени състоянието на звука
        mute = !mute;
    }

    // Отваря сцената PlayScene, когато бутонът PLAY е натиснат:
    public void openPlay()
    {
        Sound.mute = mute;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads next scene with build number x+1
    }

}