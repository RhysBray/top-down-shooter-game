using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunshotMovement : MonoBehaviour
{
    public float speed = 10;

    private Vector2 target;

    private void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target) < 0.1f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
        Destroy(gameObject);
        }
    }
}
