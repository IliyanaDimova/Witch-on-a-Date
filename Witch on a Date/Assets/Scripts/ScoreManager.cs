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
    int butterflyScore = 0, flowerScore = 0, frogScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
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
    }
}
