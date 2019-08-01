using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemyMiniBoss;
    public Transform[] spawnPoints;

    public float spawnTime = 2f;
    public float difficultyMultiplier = 0.998f;
    public float spawnsUntilMiniBoss = 15f;

    private GameObject player;

    private int enemyCounter = 0;
    private int miniBossAmount = 0;
    private float spawnTimer;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawnTimer = spawnTime;
    }

    private void Update()
    {
        if(player)
        {
            if(enemyCounter % spawnsUntilMiniBoss == 0)
            {
                for(int i = 1; i <= miniBossAmount; i++)
                {
                    int randomPositon = Random.Range(0, spawnPoints.Length);
                    Instantiate(enemyMiniBoss, spawnPoints[randomPositon].position, Quaternion.identity);
                }
                miniBossAmount += 1;
                enemyCounter += 1;

            }

            if (spawnTimer <= 0)
            {
                int randomPositon = Random.Range(0, spawnPoints.Length);
                Instantiate(enemy, spawnPoints[randomPositon].position, Quaternion.identity);
                spawnTime *= difficultyMultiplier;
                spawnTimer = spawnTime;
                enemyCounter += 1;
            }
            else
            {
                spawnTimer -= Time.deltaTime;
            }
        }
    }
}
