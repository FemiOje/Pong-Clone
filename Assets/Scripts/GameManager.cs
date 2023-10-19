using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public int playerScore;
    public int computerScore;
    public TMPro.TextMeshProUGUI playerScoreText;
    public TMPro.TextMeshProUGUI computerScoreText;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public void PlayerScored()
    {
        playerScore++;
        playerScoreText.text = $"{playerScore}";
        ResetScene();
    }

    public void ComputerScored()
    {
        computerScore++;
        computerScoreText.text = $"{computerScore}";
        ResetScene();
    }

    public void ResetScene()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
    }

}
