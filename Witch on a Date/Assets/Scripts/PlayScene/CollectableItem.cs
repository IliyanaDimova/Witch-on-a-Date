using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    // Задейства се когато предмета се "докосне" до чужд Collider
    private void OnTriggerEnter2D()
    {
        // Ако докоснатия обект е пеперуда
        if (gameObject.CompareTag("butterfly"))
        {
            ScoreManager.instance.ChangeScore(1);
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("flower"))
        {
            // Смени броя на събраните пеперуди
            ScoreManager.instance.ChangeScore(2);
            // Унищожи обекта
            Destroy(gameObject);
        }
        // Ако докоснатия обект е жаба
        if (gameObject.CompareTag("frog"))
        {
            ScoreManager.instance.ChangeScore(3);
            Destroy(gameObject);
        }
    }

}
