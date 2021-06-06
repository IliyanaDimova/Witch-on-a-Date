using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour
{
    // Фоновия звук на играта
    public AudioSource audioSource;
    // Променлива в която съхранявам дали играта е със спрян звук
    public static bool mute;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Ако mute е true заглушавам звука на audioSource
        if (mute)
        {
            audioSource.mute = true;
        }
    }

}
