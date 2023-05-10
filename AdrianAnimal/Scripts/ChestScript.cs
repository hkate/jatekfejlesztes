using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    public bool locked = true;
    public GameObject closed;
    public GameObject opened;
    public GameManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !locked)
        {
            closed.SetActive(false);
            opened.SetActive(true);
            manager.victoryShow();
        }
    }
}
