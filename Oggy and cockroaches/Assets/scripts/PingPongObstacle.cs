using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongObstacle : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float changeDirectionTime = 2f;

    private Rigidbody2D rb;
    private Vector2 movementDirection;
    private float timeSinceLastDirectionChange;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ChangeMovementDirection();
    }

    private void Update()
    {
        timeSinceLastDirectionChange += Time.deltaTime;

        if (timeSinceLastDirectionChange >= changeDirectionTime)
        {
            ChangeMovementDirection();
            timeSinceLastDirectionChange = 0f;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = movementDirection * moveSpeed;
    }

    private void ChangeMovementDirection()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        movementDirection = new Vector2(randomX, randomY).normalized;
    }
}
