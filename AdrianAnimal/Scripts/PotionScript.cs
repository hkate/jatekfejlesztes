using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.potionConsumed();
            Instantiate(this.gameObject, new Vector3(Random.Range(-20, 20), 0.1f, Random.Range(-20, 20)), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
