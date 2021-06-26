using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMix : MonoBehaviour
{
    // Променлива в която съхранявам дали играта е със спрян звук
    public static bool mute;

    // Start is called before the first frame update
    void Start()
    {
        Sound.mute = mute;
    }
}
