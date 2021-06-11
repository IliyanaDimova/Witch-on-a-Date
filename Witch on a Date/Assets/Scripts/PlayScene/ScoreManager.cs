using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    // Текстът който ще се променя за брой събрани пеперуди, цветя и жаби
    public TextMeshProUGUI butterflyText, flowerText, frogText;
    // Брой събрани пеперуди, цветя и жаби
    public static int butterflyScore, flowerScore, frogScore;

    // Звукът който ще се изпълнява
    public AudioClip triggerSound;
    // AudioSourc-а в ScoreManager
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        // Нулирам скора преди да започне играта
        butterflyScore = 0;
        flowerScore = 0;
        frogScore = 0;

        // Откривам AudioSourc-а в ScoreManager
        audioSource = GetComponent<AudioSource>();
    }

    // Променя текста за брой събрани елементи
    // tag е 1 за пеперуда, 2 за цвете и 3 за жаба
    public void ChangeScore(int tag)
    {
        // Ако докоснатия обект е пеперуда
        if (tag == 1)
        {
            butterflyScore += 1;
            butterflyText.text = butterflyScore.ToString();
        }
        // Ако докоснатия обект е цвете
        if (tag == 2)
        {
            flowerScore += 1;
            flowerText.text = flowerScore.ToString();
        }
        // Ако докоснатия обект е жаба
        if (tag == 3)
        {
            frogScore += 1;
            frogText.text = frogScore.ToString();
        }

        // Изпълни звук на събиране на съставка ако играта не е заглушена
        if (!Sound.mute)
        {
            playCollectSound();
        }
    }

    // Изпълнява звука за събиране на съставка
    void playCollectSound()
    {
        audioSource.PlayOneShot(triggerSound, 0.3F);
    }
}
