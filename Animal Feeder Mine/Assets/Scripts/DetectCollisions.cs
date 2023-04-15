using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) { //if the colliders collide with one another it will do something
        Destroy(gameObject); // the food
        Destroy(other.gameObject); // the animal
    }
}
