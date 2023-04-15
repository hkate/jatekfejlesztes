using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int timeLeft;
    public TextMeshProUGUI timeText;

    private void Start()
    {
        timeText.SetText("Time: " + timeLeft);
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            timeText.SetText("Time: " + timeLeft);
        }
        GameOver();
    }
    public void GameOver()
    {
        Debug.Log("...");
        player.GetComponent<PlayerController>().enabled= false;
    }
}
