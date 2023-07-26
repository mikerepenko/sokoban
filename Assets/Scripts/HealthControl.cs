using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthControl : MonoBehaviour
{
    [SerializeField] Text waitTimeText;

    Text timeText;
    Text valueText;

    int health;
    float timeRemaining = 69;
    bool timerIsRunning = false;

    void Start()
    {
        valueText = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
        timeText = gameObject.transform.GetChild(1).gameObject.GetComponent<Text>();
        Button healthButton = gameObject.transform.GetChild(2).gameObject.GetComponent<Button>();

        health = PlayerPrefs.GetInt("health");

        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);  
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} min {1:00} sec", minutes, seconds);
        waitTimeText.text = "Wait: " + string.Format("{0:00} min {1:00} sec", minutes, seconds);
    }
}
