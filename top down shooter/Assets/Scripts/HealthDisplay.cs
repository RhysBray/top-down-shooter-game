using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private Text text;

    private GameObject player;
    private string health;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text = gameObject.GetComponent<Text>();
    }


    private void Update()
    {
        health = player.GetComponent<Player>().health.ToString();
        text.text = "HP: " + health;
    }
}
