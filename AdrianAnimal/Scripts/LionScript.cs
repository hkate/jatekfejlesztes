using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LionScript : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.helpShow(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.helpShow(false);
        }
    }
}
