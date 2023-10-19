using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public int playerScore;
    public int computerScore;
    public TMPro.TextMeshProUGUI playerScoreText;
    public TMPro.TextMeshProUGUI computerScoreText;
    public GameObject playerPaddle;
    public GameObject computerPaddle;

    public void PlayerScored()
    {
        playerScore++;
        playerScoreText.text = $"{playerScore}";
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        ResetPaddlePositions();
    }

    public void ComputerScored()
    {
        computerScore++;
        computerScoreText.text = $"{computerScore}";
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        ResetPaddlePositions();
    }

    public void ResetPaddlePositions()
    {
        playerPaddle.transform.position = new Vector2(playerPaddle.transform.position.x, 0.0f);
        computerPaddle.transform.position = new Vector2(computerPaddle.transform.position.x, 0.0f);
    }
}
