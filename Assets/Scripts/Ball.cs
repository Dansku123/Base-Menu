using UnityEngine;

public class Ball : MonoBehaviour
{
    public float startSpeed = 5f;
    public Rigidbody2D rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        LaunchBall();
    }

    void LaunchBall()
    {
        rb.linearVelocity = Vector2.zero;

        Vector2 startDirection = new Vector2(Random.Range(-1f, 1f), 1);
        rb.linearVelocity = startDirection * startSpeed;
    }

    void Update()
    {
        if (gameObject.transform.position.y < -5.0f)
        {
            LaunchBall();
        }
    }
}
