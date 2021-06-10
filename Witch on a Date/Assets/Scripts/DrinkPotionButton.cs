using UnityEngine;
using UnityEngine.SceneManagement;

public class DrinkPotionButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void drinkPotion()
    {
        // Отваря Result scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4); 
    }
}
