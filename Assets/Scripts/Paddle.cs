using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    protected Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            this.speed += 10.0f;
        }
    }
}
