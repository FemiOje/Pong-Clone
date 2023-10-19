using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballRb;
    public float speed;

    private void Awake()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
    }

    public void ResetPosition()
    {
        ballRb.position = Vector2.zero;
        ballRb.velocity = Vector2.zero;
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        ballRb.AddForce(direction * speed * Time.deltaTime);
    }

    public void AddForce(Vector2 force)
    {
        ballRb.AddForce(force);
    }
}
