using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool selected = false;
    public GameObject car;
    public GameObject bus;
    public FollowPlayer cam;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI chooseText;
    public int timeCount = 0;

    public GameObject human;
    public int humanTime;

    void Start()
    {
        StartCoroutine(time());
        humanTime = UnityEngine.Random.Range(60, 120);
    }

    IEnumerator time()
    {
        while (true)
        {
            if (selected) timeCount++;
            timerText.text = timeCount.ToString();
            yield return new WaitForSeconds(1);
        }
    }

    void Update()
    {
        if (!selected && Input.GetKeyUp(KeyCode.Alpha1))
        {
            selected = true;
            Debug.Log("kocsi 1");
            cam.player = Instantiate(car);
            chooseText.enabled = false;
        }
        else if (!selected && Input.GetKeyUp(KeyCode.Alpha2))
        {
            selected = true;
            Debug.Log("bus 2");
            cam.player = Instantiate(bus);
            chooseText.enabled = false;
        }

        //Human
        if (humanTime > 0)
        {
            if (selected) humanTime--;
        }
        else
        {

            if (human.transform.position.x < 24)
            {
                human.transform.position = human.transform.position + new Vector3(0.05f, 0, 0);
                human.GetComponent<Animator>().SetFloat("MoveSpeed", 1);
            }
            else
            {
                human.GetComponent<Animator>().SetFloat("MoveSpeed", -1);
            }
        }
    }
}