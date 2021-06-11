using UnityEngine;
using TMPro;

public class MuteButtonText : MonoBehaviour
{
    // Текста на Mute бутона
    public TextMeshProUGUI changeText;

    // Start is called before the first frame update
    void Start()
    {
        if (Buttons.mute)
        {
            // Смени текста на бутона на UNMUTE
            changeText.text = "UNMUTE";
        }
    }
}
