using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f; // скорост на движение на играча
    public Rigidbody2D rb; // Rigidbody2D на играча
    Vector2 movement; // тук ще съхранявам User Input

    /* Тук ще приемам Input сигналите */
    void Update()
    {
        movement.x = moveSpeed; // константно движение по X със скорост moveSpeed
        movement.y = Input.GetAxisRaw("Vertical"); // User Input по Y
    }

    /* Тук ще изпълнявам движенията на играча */
    void FixedUpdate()
    {
        /* Time.fixedDeltaTime запазва moveSpeed константно. Това прави движението гладко.*/
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
