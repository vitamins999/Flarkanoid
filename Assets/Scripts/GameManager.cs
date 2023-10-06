using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int playerLives = 3;
    public static int playerScore = 0;

    public AudioSource[] gameOverSFX;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        gameOverSFX = GetComponents<AudioSource>();
    }

    public void Start()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void PlayerLoseLife()
    {

        playerLives--;

        if (playerLives == 0)
        {
            gameOverSFX[1].Play();
            Invoke("GameOver", 2.0f);
        } else
        {
            gameOverSFX[0].Play();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}
