using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // ez csak azért kell h bármelyik gameobject lehet player?
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; //távolságtartához kell
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = player.transform.position; //kerekeket mutatja
        transform.position = player.transform.position + offset;
    }
}
