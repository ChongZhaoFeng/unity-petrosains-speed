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

    public Text reactText;

    public Text time;
    public Text countdown;

    public GameObject startarea;
    public GameObject carMove;
    public GameObject carMove1;
    public GameObject canMove;
    public GameObject stopSign;

    public bool start = false; 
    public bool start2 = false;
    public bool pGame = false;
    

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
        
        canMove.GetComponent<LPPV_CarController>().enabled = false;
        carMove.GetComponent<CarEngine>().enabled = false;
        carMove1.GetComponent<CarEngine>().enabled = false;

        
    }

    public void Update()
    {
        
        if (start)
        {
            canMove.GetComponent<LPPV_CarController>().enabled = true;
            milli += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.W))
            {
                start = false;
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

            if (sec < 10)
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
        }


        ////////////////////////////////////////////////////////////////////////////////////

        if (pGame == true)
        {
            Time.timeScale = 0f;
        }
       

        if (start2)
        {
            
            milli += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.Space))
            {
                start2 = false;
                pGame = true;
                canMove.GetComponent<LPPV_CarController>().enabled = false;
                canMove.GetComponent<Rigidbody>().velocity = Vector3.zero;
          
            
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

            if (sec < 10)
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


        }




    }

    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().tag == "Wall")
        {
            carMove.GetComponent<CarEngine>().enabled = true;
            carMove1.GetComponent<CarEngine>().enabled = true;

            reactText.text = "Reaction two";

            milli = 0;
            min = 0;
            sec = 0;
            
        }

        if (col.GetComponent<Collider>().tag == "Wall2")
        {
            stopSign.SetActive(true);
            start2 = true;


        }
        
        

    }

  
}
