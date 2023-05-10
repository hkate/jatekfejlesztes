using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    public float speed;
    CharacterController controller;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // transform.Translate(new Vector3(horizontal, 0, vertical) 
       // * speed * Time.deltaTime);
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        controller.SimpleMove(dir * speed);

        if(horizontal == 0 && vertical == 0)
        {
            animator?.SetBool("Walk_b", false);
        }
        else
        {
            transform.forward = -dir;
            animator?.SetBool("Walk_b", true);
        }
    }
}
