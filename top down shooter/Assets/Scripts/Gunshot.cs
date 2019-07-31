using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshot : MonoBehaviour
{
    public GameObject gunshot;
    private Transform playerTransform;

    private void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(gunshot, playerTransform.position, Quaternion.identity);
        }
    }
}
