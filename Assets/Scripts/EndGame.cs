using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public TMP_Text gameOverText;
    public TMP_Text youWinText;
    public TMP_Text finalScoreText;

    public AudioSource[] endGameMusic;

    private void Awake()
    {
        int livesLeft = GameManager.playerLives;
        int finalScore = GameManager.playerScore;

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

        finalScoreText.text = finalScore.ToString();
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("Quit!");
            Application.Quit();
        }
    }
}
