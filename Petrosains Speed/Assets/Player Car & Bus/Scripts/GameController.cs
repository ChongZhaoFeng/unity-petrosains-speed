using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Text timeCounter, countdownText, feedbackText;
    public bool gamePlaying { get; private set; }
    
    public int countdownTime;
    private float startTime, elapsedTime;
    TimeSpan timePlaying;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

        gamePlaying = false;

        feedbackText.gameObject.SetActive(false);

        StartCoroutine(CountdownToStart());


    }
    private void BeginGame()
    {
        gamePlaying = true;
        

        startTime = Time.time;

    }




    private void Update()
    {
        

        if (gamePlaying)
        {
            elapsedTime = Time.time - startTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);

            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;

           
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            gamePlaying = false;
            countdownText.gameObject.SetActive(false);
            feedbackText.gameObject.SetActive(true);
           
        }



    }

  
     

IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        BeginGame();

        countdownText.text = "GO!";

        yield return new WaitForSeconds(1f);

        
        countdownText.gameObject.SetActive(false);

       

    }
}
