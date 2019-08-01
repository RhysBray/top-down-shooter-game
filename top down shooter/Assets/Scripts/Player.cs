using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float health = 10f;

    private Rigidbody2D rb;
    private Vector2 velocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            Debug.Log("YOU HAVE DIED!");
            Destroy(gameObject);
        }

        Vector2 movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        velocity = movementDirection.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.deltaTime);
    }
}
