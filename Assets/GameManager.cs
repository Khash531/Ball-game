using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float RestartDelay = 2f;
    public void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GameOver ()
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            Invoke("RestartGame", RestartDelay);
        }
    }

    void RestartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
