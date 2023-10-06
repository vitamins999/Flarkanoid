using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public TMP_Text gameOverText;
    public TMP_Text youWinText;
    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;

    public AudioSource[] endGameMusic;

    int livesLeft = GameManager.playerLives;
    int finalScore = GameManager.playerScore;

    private void Awake()
    {
        endGameMusic = GetComponents<AudioSource>();

        if (livesLeft > 0)
        {
            endGameMusic[0].Play();

            gameOverText.enabled = false;
            finalScore *= livesLeft;
        } else
        {
            endGameMusic[1].Play();
            youWinText.enabled = false;
        }

        getAndSetHighScore();
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("Quit!");
            Application.Quit();
        }
    }

    private void getAndSetHighScore()
    {
        finalScoreText.text = finalScore.ToString();

        int highscore = PlayerPrefs.GetInt("highscore", 0);

        if (finalScore > highscore)
        {
            highscore = finalScore;
        }

        highScoreText.text = highscore.ToString();
        PlayerPrefs.SetInt("highscore", highscore);
    }
}
