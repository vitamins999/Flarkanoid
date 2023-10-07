using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int playerLives = 3;
    public static int playerScore = 0;

    public Block[] blocks;
    public int numberOfBlocks;

    public AudioSource[] gameOverSFX;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnLevelLoaded;

        gameOverSFX = GetComponents<AudioSource>();
    }

    public void Start()
    {
        SceneManager.LoadScene("Main Menu");
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        blocks = FindObjectsOfType<Block>();
        numberOfBlocks = blocks.Length;
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

    private bool Cleared()
    {
        if (numberOfBlocks > 0) {
            Debug.Log(numberOfBlocks);
            return false; }

        return true;
    }

    public void Hit()
    {
        playerScore += 10;

        if (Cleared())
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    public void BlockDestroyed()
    {
        numberOfBlocks--;
    }
}
