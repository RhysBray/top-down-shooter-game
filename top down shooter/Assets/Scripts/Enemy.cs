using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject splatter;
    public float speed = 5f;
    public float Enemyhealth = 2f;
    public float hitScore = 10f;
    public float killScore = 50f;

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
            Instantiate(splatter, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (other.CompareTag("Projectiles"))
        {
            Enemyhealth--;
            gameController.GetComponent<Score>().score += hitScore;
            if(Enemyhealth <= 0)
            {
                gameController.GetComponent<Score>().score += killScore;
                Instantiate(splatter, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
