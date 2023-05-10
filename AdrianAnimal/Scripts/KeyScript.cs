using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private int time = 3;
    public MeshRenderer renderer;
    public ChestScript chestScript;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            renderer.enabled = true;
            time = 3;
            StartCoroutine(timer());
        }
    }

    IEnumerator timer()
    {
        while(time > 0)
        {
            time--;
            yield return new WaitForSeconds(1);
        }
        renderer.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            chestScript.locked = false;
            Destroy(this.gameObject);
        }
    }
}
