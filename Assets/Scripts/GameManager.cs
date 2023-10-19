using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public int playerScore;
    public int computerScore;

    public void PlayerScored()
    {
        playerScore++;
        this.ball.ResetPosition();
    }

    public void ComputerScored()
    {
        computerScore++;
        this.ball.ResetPosition();
    }
}
