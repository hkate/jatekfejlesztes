using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPosition;
    float width;
    public float speed;

    void Start()
    {
        startPosition = transform.position;
        width = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x < startPosition.x - width)
        {
            transform.position = startPosition;
        }
    }
}


