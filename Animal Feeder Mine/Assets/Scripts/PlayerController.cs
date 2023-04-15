using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject food;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D) && transform.position.x < 20)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A) && transform.position.x > -20)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space)) //ha space-t nyom csinál egy clone a kajából és "eldobja
        {
            Instantiate(food, transform.position + new Vector3(0,2.2f,0),
                food.transform.rotation);
        }

    }
}
