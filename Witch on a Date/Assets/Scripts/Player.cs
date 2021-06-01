using UnityEngine;

public class Player : MonoBehaviour
{
    // Скорост на движение на играча
    public float moveSpeed = 10f;
    // Rigidbody2D на играча
    public Rigidbody2D rb;
    // Съхранява User Input
    Vector2 movement;
    // Пази информация за докосване по екрана
    private Vector3 touchPos;

    // Ограничения по У за да стои винаги в рамките на екрана
    private float yMin, yMax; 

    void Start()
    {
        // Вземам главната камера
        Camera camera = Camera.main;
        yMin = camera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        yMax = camera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    }

    // Тук ще приемам Input сигналите 
    void Update()
    {
        TouchInput();
    }

    // Тук ще изпълнявам движенията на играча 
    void FixedUpdate()
    {
        Movement();
    }

    // Проверява дали играча е в рамките на екрана
    bool PlayerOnScreen()
    {
        // Ако играча е в рамките на екрана по У => връща true 
        // (=/- 1.5 за да не излиза изображението наполовина извън екрана)
        if ((rb.position.y > yMin + 1.5) && (rb.position.y < yMax-1.5))
            return true;
        // Ако играча е стигнал долния ъгъл на екрана, но юзъра е натиснал екрана за да го качи нагоре
        if ((rb.position.y <= yMin + 1.5) && (touchPos.y > 0))
            return true;
        // Ако играча е стигнал горния ъгъл на екрана, но юзъра е натиснал екрана за да го свали надолу
        if ((rb.position.y >= yMax - 1.5) && (touchPos.y < 0))
            return true;
        
        // Ако играча е извън допустимите граници и няма User Input
        return false;
    }

    // Проверява дали има докосване по екрана
    void TouchInput()
    {
        // Kонстантно движение по X със скорост moveSpeed
        movement.x = moveSpeed;

        // Ако има докосване 
        if (Input.GetMouseButton(0)) 
        {
            // Съхранявам информацията за първото докосване по екрана
            touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        }
        // Ако няма докосване
        else
        {
            // Нулирам touchPos
            touchPos.x = 0f;
            touchPos.y = 0f;
            touchPos.z = 0f;
        }
    }

    // Премества играча чрез докосване по екрана
    void Movement()
    {
        // Aко докосвам горната част на екрана и играча е в рамките на екрана
        if (touchPos.y > 0 && PlayerOnScreen()) 
        {
            transform.Translate((moveSpeed * Time.fixedDeltaTime) * moveSpeed, (moveSpeed * Time.fixedDeltaTime), 0);
        }
        // Aко докосвам долната част и играча е в рамките на екрана
        else if (touchPos.y < 0 && PlayerOnScreen())
        {
            transform.Translate((moveSpeed * Time.fixedDeltaTime) * moveSpeed, -(moveSpeed * Time.fixedDeltaTime), 0);
        }
        // Ако няма докосване
        else
        {
            // Time.fixedDeltaTime запазва moveSpeed константно. Това прави движението гладко
            // Пемествам играча със зададената скорост
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); 
        }
    }
}
