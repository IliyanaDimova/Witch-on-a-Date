using UnityEngine;

public class Parallax : MonoBehaviour
{
    // променливи:
    private float length, startpos; // дължината и началната позиция на спрайта
    public GameObject cam; // камерата
    public float parallaxEffect; // стойност за прилагане на ефекта Parallax

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // temp е колко далеко съм пътувала спрямо (релативно на) камерата
        float temp = (cam.transform.position.x * (1 - parallaxEffect));

        // dist е колко далеко съм стигнала в пространството на играта
        float dist = (cam.transform.position.x * parallaxEffect); 

        // Променяне на позицията
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        // Повторение на картинките за напред и назад
        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
