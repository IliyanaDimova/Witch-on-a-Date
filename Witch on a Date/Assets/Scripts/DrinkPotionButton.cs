﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class DrinkPotionButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void drinkPotion()
    {
        // Ако има събрани 6 жаби, 3 цветя, 7 пеперуди
        if (MixScoreManager.frogScore == 6 && MixScoreManager.butterflyScore == 3 && MixScoreManager.flowerScore == 7)
        {
            // Отваря Date сцена
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        // Ако в събраните съставки преобладават жаби
        else if (MixScoreManager.frogScore > MixScoreManager.butterflyScore && MixScoreManager.frogScore > MixScoreManager.flowerScore)
        {
            // Отваря Frog Result сцена
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4); 
        }
        // Ако преобладават цветята
        else if (MixScoreManager.flowerScore > MixScoreManager.frogScore && MixScoreManager.flowerScore > MixScoreManager.butterflyScore)
        {
            // Отваря Flower Result сцена
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        // Всички други случаи
        else
        {
            // Отваря Butterfly Result сцена
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}