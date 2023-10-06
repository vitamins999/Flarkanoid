using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public TMP_Text gameOverText;
    public TMP_Text youWinText;
    public TMP_Text finalScoreText;

    private void Awake()
    {
        int livesLeft = GameManager.playerLives;
        int finalScore = GameManager.playerScore;

        if (livesLeft > 0)
        {
            gameOverText.enabled = false;
            finalScore *= livesLeft;
        } else
        {
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
