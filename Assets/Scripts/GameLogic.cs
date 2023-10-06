using TMPro;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public static int numberOfBalls = 0;
    public TMP_Text livesText;
    public TMP_Text scoreText;

    private void Update()
    {
        livesText.text = "x " + GameManager.playerLives.ToString();
        scoreText.text = GameManager.playerScore.ToString();
    }
}
