using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ballRb;

    private void FixedUpdate()
    {
        if (ballRb.velocity.x > 0.0f)
        {
            if (ballRb.position.y > transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed * Time.deltaTime);
            }
            else if (ballRb.position.y < transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed * Time.deltaTime);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * this.speed * Time.deltaTime);
            }
            else if (this.transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this.speed * Time.deltaTime);
            }
        }
    }
}
