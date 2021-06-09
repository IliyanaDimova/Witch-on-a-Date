using System.Collections.Generic;
using UnityEngine;

public class PotionMixAnimations : MonoBehaviour
{
    // Сегашно време
    float currentTime = 0f;
    // Задавам вектор среда на екрана
    Vector3 temp1;

    void Start()
    {
        temp1 = transform.position;
        temp1.y = 0;
        temp1.x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Намалям времето с една секунда
        currentTime += 1 * Time.deltaTime;

        // Ако са изминали 6 секунди
        if (currentTime >= 3 && currentTime <= 4)
        {
            // Показвам Smoke обекта, премествайки го на позиция (0, 0) което е средатата на екрана
            transform.position = temp1;
        }
    }
}
