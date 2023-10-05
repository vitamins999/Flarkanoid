using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int playerLives = 3;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayerLoseLife()
    {
        Debug.Log("Player lost life");
        playerLives--;

        if (playerLives == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("GameOver!");
    }
}
