using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //UI
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI failedText;
    public TextMeshProUGUI victoryText;
    public TextMeshProUGUI helpText;

    //Dog things
    public int health=10;
    public bool canBleed = true;

    void Start()
    {
        StartCoroutine(bleeding());
    }

    IEnumerator bleeding()
    {
        while(health > 0)
        {
            if(canBleed) health--;
            healthTextUpdate();
            yield return new WaitForSeconds(2);
        }

        failedText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void potionConsumed()
    {
        health += 5;
        healthTextUpdate();
    }

    private void healthTextUpdate()
    {
        healthText.text = "HP: " + health.ToString();
    }

    public void helpShow(bool show)
    {
        helpText.gameObject.SetActive(show);
    }

    public void victoryShow()
    {
        victoryText.gameObject.SetActive(true);
        canBleed = false;
    }
}
