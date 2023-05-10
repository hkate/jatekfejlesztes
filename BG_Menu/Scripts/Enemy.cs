using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject gm;
    public GameObject bullet, player;
    float distance = 1000;
    private void Start()
    {
        gm = GameObject.Find("GameManager");
        StartCoroutine(Shoot());
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        distance = Vector3.Distance(transform.position,
            player.transform.position);
        Debug.Log("tav: " + distance);
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            if (distance < 45)
            {
                yield return new WaitForSeconds(1);
                GameObject newBullet = Instantiate(bullet, transform.position,
                    bullet.transform.rotation);
                Vector3 dir = player.transform.position
                    - transform.transform.position;
                newBullet.transform.forward = new Vector3(dir.x, 0, dir.z);
            }
            yield return null;
            
        }

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
