using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunshotMovement : MonoBehaviour
{
    public float speed = 10;
    public float despawnTime = 2f;

    private Vector2 fireDirection;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        fireDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - player.transform.position;
    }

    private void Update()
    {
        transform.Translate(fireDirection.normalized * speed * Time.deltaTime);
        
        Destroy(gameObject, despawnTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
        Destroy(gameObject);
        }
    }
}
