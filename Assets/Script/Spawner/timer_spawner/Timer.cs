using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    private Spawner_timer mySpawner;

    public float timeRemaining = 45;
    public bool timerIsRunning = false;
    public Text timeText;

    public GameObject spawn;
    private void Start()
    {
        // start automatiquement le spawn
        timerIsRunning = true;
        mySpawner = GetComponent<Spawner_timer>();
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
                Destroy(obj: gameObject);

            }
            
        }


       
    }

    

   
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }




}