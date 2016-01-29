using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
