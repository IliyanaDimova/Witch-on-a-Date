using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MixScoreManager : MonoBehaviour
{
    public static MixScoreManager instance;
    // Текстът който ще се променя за брой събрани пеперуди, цветя и жаби
    public TextMeshProUGUI butterflyText, flowerText, frogText;
    // Брой събрани пеперуди, цветя и жаби
    public static int butterflyScore, flowerScore, frogScore;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        
        // Променям текста за брой събрани елементи
        butterflyText.text = butterflyScore.ToString();
        flowerText.text = flowerScore.ToString();
        frogText.text = frogScore.ToString();
    }

}
