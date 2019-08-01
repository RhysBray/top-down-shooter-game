using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;
    public float spawnTime = 2f;
    public float difficultyMultiplier = 0.995f;

    private float spawnTimer;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawnTimer = spawnTime;
    }

    private void Update()
    {
        if(player)
        {
            if (spawnTimer <= 0)
            {
                int randomPositon = Random.Range(0, spawnPoints.Length);
                Instantiate(enemy, spawnPoints[randomPositon].position, Quaternion.identity);
                spawnTime *= difficultyMultiplier;
                spawnTimer = spawnTime;
            }
            else
            {
                spawnTimer -= Time.deltaTime;
            }
        }
    }
}
