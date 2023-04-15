using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject gm;
    private void Start()
    {
        gm = GameObject.Find("GameManager");  
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            gm?.GetComponent<GameManager>().GameOver();

        }
    }
}
