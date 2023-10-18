using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ballRb;


    private void FixedUpdate()
    {
        if (ballRb.position.x > 0.0f && ballRb.velocity.x > 0.0f)
        {
            if (ballRb.position.y > transform.position.y)
            {
                //move up
                _rigidbody.AddForce(Vector2.up * this.speed * Time.deltaTime);
            }
            else if (ballRb.position.y < transform.position.y)
            {
                //move down
                _rigidbody.AddForce(Vector2.down * this.speed * Time.deltaTime);
            }
        }
        else
        {
            //move to the middle
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
