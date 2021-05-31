using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // обекта, който камерата следи
    public Vector3 offset; // отгалечаване от целта

    void FixedUpdate()
    {
        transform.position = target.position + offset; // следи целта
    }
}
