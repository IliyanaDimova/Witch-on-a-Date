using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // обекта, който камерата следи
    public Vector3 offset; // отгалечаване от целта
    private Vector3 targetWithoutY; // позицията на target, но винаги е 0 по Y кординатата

    /*// PROBA
    // Координата Х за началото на екрана
    private float xMax;
    void Start()
    {
        // Вземам главната камера
        Camera camera = Camera.main;
        xMax = camera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        offset.x = xMax - 2;
    }*/

    void FixedUpdate()
    {
        targetWithoutY = target.position; // targetWithoutY получава позицията на играча
        targetWithoutY.y = 0f; // targetWithoutY загубва позицията на играча по Y
        transform.position = targetWithoutY + offset; // следи целта
    }
}
