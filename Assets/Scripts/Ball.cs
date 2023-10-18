using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballRb;
    public float speed = 200.0f;

    private void Awake()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        AddStartingForce();
    }


    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);

        ballRb.AddForce(direction * speed * Time.deltaTime);
    }
}
