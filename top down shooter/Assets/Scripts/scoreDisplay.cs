using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreDisplay : MonoBehaviour
{
    private Text text;

    private GameObject gameController;
    private string score;

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        text = gameObject.GetComponent<Text>();
    }
   
    private void Update()
    {
        score = Mathf.Floor(gameController.GetComponent<Score>().score).ToString();
        text.text = score;
    }
}
