using UnityEngine;

public class PotionMixAnimations : MonoBehaviour
{
    // Падащо цвете, пеперуда или жаба, чиято позиция ще ми показва дали вече да 
    // пусна Smoke анимацията или да покажа бутона Drink Potion
    public Rigidbody2D starter;
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
        // Ако starter е паднал на позиция под у = -14 и гравитацията му не се е нулирала (if-а не се е изпълнявал досега)
        if (starter.position.y <= -14 && starter.gravityScale != 0)
        {
            // Показвам Smoke обекта, премествайки го на позиция (0, 0) което е средатата на екрана
            transform.position = temp1;

            // Нулирам гравитацията на starter
            starter.gravityScale = 0f;
        }
    }
}
