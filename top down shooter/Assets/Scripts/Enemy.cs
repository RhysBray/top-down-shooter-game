using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public float Enemyhealth = 2f;

    private GameObject player;
    private GameObject gameController;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    private void Update()
    {
        if(player)
        {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<Player>().health--;
            Destroy(gameObject);
        }

        if (other.CompareTag("Projectiles"))
        {
            Enemyhealth--;
            gameController.GetComponent<Score>().score += 10f;
            if(Enemyhealth <= 0)
            {
                gameController.GetComponent<Score>().score += 50f;
                Destroy(gameObject);
            }
        }
    }
}
