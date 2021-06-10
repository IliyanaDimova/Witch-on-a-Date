using UnityEngine;
using UnityEngine.SceneManagement;

public class LoopGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Ако екрана е докоснат
        if (Input.GetMouseButton(0))
        {
            // Отваря Main Menu сцена с индекс 0
            SceneManager.LoadScene(0);
        }
    }
}
