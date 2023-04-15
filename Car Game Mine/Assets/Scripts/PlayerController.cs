using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float rspeed = 30f;
    public int counter = 0;
    public int maxCoins;

    // Start is called before the first frame update
    void Start()
    {
        maxCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(verticalInput * Vector3.forward * speed * Time.deltaTime);

        float horizontalinput = Input.GetAxis("Horizontal");

        //transform.Translate(horizontalinput * Vector3.right * speed * Time.deltaTime);
        transform.Rotate(Vector3.up, horizontalinput * rspeed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            speed *= 5;
        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            speed /= 5;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("utkozes"); // üzenetet küld mindig ha érintkezik vele
        //Destroy(other.gameObject); //felveszi a coint //destroyyal teljesen eltűnik a hierarchiából is
        other.gameObject.SetActive(false); //coin-ját is inaktívvá tudod tenni, hierarciában is megjelenik
        counter++;
        if(counter == maxCoins)
        {
            Debug.Log("Nyertel");

            GetComponent<PlayerController>().enabled = false;
        }
    }

}
