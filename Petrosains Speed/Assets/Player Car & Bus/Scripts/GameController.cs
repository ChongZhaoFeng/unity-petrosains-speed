using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float milli;
    public int sec;
    public int min;

    public string milliDisplay;
    public string secDisplay;
    public string minDisplay;

    public Text time;
    public Text countdown;

    public GameObject startarea;

    public bool start = false;
    public GameObject canMove;

    public string[] time_store;

    

    public IEnumerator CountDown()
    {
        countdown.text = " ";
        int wait_time = Random.Range(3, 6);
        yield return new WaitForSeconds(wait_time);
        startarea.SetActive(false);
        countdown.text = "GO!";
        start = true;
        yield return new WaitForSeconds(1f);
        countdown.text = " ";
    }

    private void Start()
    {
        StartCoroutine(CountDown());
        canMove.GetComponent<LPPV_CarController>().enabled = false;
    }

    private void Update()
    {
        if (start)
        {
            canMove.GetComponent<LPPV_CarController>().enabled = true;
            milli += Time.deltaTime * 100;
        }
        if (milli >= 100)
        {
            milli = 0;
            sec += 1;
        }
        if (sec >= 60)
        {
            sec = 0;
            min += 1;
        }
        milliDisplay = "" + milli.ToString("F1");

        if(sec < 10)
        {
            secDisplay = "0" + sec.ToString();
        }
        else
        {
            secDisplay = sec.ToString();
        }
        if (min < 10)
        {
            minDisplay = "0" + min.ToString();
        }
        else
        {
            minDisplay = min.ToString();
        }
        time.text = minDisplay + ":" + secDisplay + ":" + milliDisplay;

        if(Input.GetKey(KeyCode.W))
        {
            start = false;
        }
    }
}
