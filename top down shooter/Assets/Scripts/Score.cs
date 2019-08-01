using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float score = 0;
    public float timeMultiplierBonus = 1f;

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if(player)
        {
            score += Time.deltaTime*5*timeMultiplierBonus;
            timeMultiplierBonus *= 1.005f;
            Debug.Log(score);
        }
    }
}
