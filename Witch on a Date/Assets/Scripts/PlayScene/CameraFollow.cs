using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // обекта, който камерата следи
    public Vector3 offset; // отгалечаване от целта
    private Vector3 targetWithoutY; // позицията на target, но винаги е 0 по Y кординатата

    /*// PROBA
    // Премести играча напред ако не се вижда
    void Start()
    {
        // Вземам главната камера
        Camera camera = Camera.main;
        float xMax = camera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        var aspectRatio = Screen.width / Screen.height;
        Debug.Log("aspect.x: " + aspectRatio);

        if (aspectRatio >= 2.3)
            offset.x = 10;
        else if (aspectRatio < 2.3 && aspectRatio >= 1.95)//target.position.x >= xMax - 2.5)
            offset.x = 9;
        else if (aspectRatio < 1.95 && aspectRatio >= 1.5)
            offset.x = 8;
        else if (aspectRatio < 1.6 && aspectRatio >= 1.5)
            offset.x = 7;
        else if (aspectRatio < 1.5)
            offset.x = 5;
        Debug.Log("offset.x: " + offset.x);
    }*/

    void FixedUpdate()
    {
        targetWithoutY = target.position; // targetWithoutY получава позицията на играча
        targetWithoutY.y = 0f; // targetWithoutY загубва позицията на играча по Y
        transform.position = targetWithoutY + offset; // следи целта
    }
}
