using System.Collections;
using System.Collections.Generic;
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
        float temp = (cam.transform.position.x * (1 - parallaxEffect)); // temp е колко далеко съм пътувала спрямо (релативно на) камерата
        float dist = (cam.transform.position.x * parallaxEffect); // dist е колко далеко съм стигнала в пространството на играта

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
