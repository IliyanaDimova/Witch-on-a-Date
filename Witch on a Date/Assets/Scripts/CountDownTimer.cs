using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// За да мога да overwrite-на текста
using UnityEngine.UI;
// За да заредя нова сцена
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    // Сегашно време
    float currentTime = 0f;
    // Начално време
    float startingTime = 30f;
    // Текст за показване
    public Text countdownText;

    void Start()
    {
        // Сегашното време = Началното време
        currentTime = startingTime;
    }

    void Update()
    {
        // Намалям времето
        currentTime -= 1 * Time.deltaTime;
        // Смени текст без да показваш стотните
        countdownText.text = currentTime.ToString("0");

        // Ако времето изтече
        if(currentTime <= 0)
        {
            // Зареждам сцената за забъркване на отвара
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        }
    }
}
