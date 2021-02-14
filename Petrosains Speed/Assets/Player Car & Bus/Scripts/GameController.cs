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
    public GameObject goodJob;
    public GameObject barrier1;
    public GameObject barrier2;

    public bool start = false; 
    public bool start2 = false;
    public bool start3 = false;
    public bool start4 = false;
    public bool start5 = false;
    public bool alreadyPlayed = false;
    public bool alreadyPlayed1 = false;


    public bool pGame = false;
    public bool cGame = false;
    public bool gGame = false;
    

    public bool pGame1 = false;
    public bool cGame1 = false;
    public bool gGame1 = false;

    public bool pGame2 = false;
    public bool cGame2 = false;
    public bool gGame2 = false;

    public bool pGame3 = false;
    public bool cGame3 = false;
    public bool gGame3 = false;






    public string[] time_store;

    public AudioSource CarHorn;
    public AudioSource tyreNoise;


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
        CarHorn = GetComponent<AudioSource>();

        
    }

    void Update()
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
            cGame = true;
        }


        if (cGame == true)
        {
            if (Input.GetKey(KeyCode.C))
            {
                gGame = true;

            }
        }

        if (gGame == true)
        {
            stopSign.SetActive(false);
            goodJob.SetActive(false);
            carMove.SetActive(false);
            carMove1.SetActive(false);
            start2 = false;
            Time.timeScale = 1f;

            
        }

        



        if (start2)
        {
            
            milli += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.Space))
            {
                stopSign.SetActive(false);
                goodJob.SetActive(true);
                start2 = false;
                pGame = true;
                
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

        ////////////////////////////////////////////////////////////////////////////////////////

        if (pGame1 == true)
        {
            
            goodJob.SetActive(true);
            Time.timeScale = 0f;
            cGame1 = true;
        }


        if (cGame1 == true)
        {
            if (Input.GetKey(KeyCode.C))
            {
                gGame1 = true;
                barrier1.SetActive(false);
            }
        }

        if (gGame1 == true)
        {
            
            start3 = false;
            goodJob.SetActive(false);
            
            Time.timeScale = 1f;

        }
       



        if (start3)
        {

            milli += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.Space))
            {
                start3 = false;
                pGame1 = true;

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

        ////////////////////////////////////////////////////////////////////////////////

        if (pGame2 == true)
        {

            goodJob.SetActive(true);
            Time.timeScale = 0f;
            cGame2 = true;
        }


        if (cGame2 == true)
        {
            if (Input.GetKey(KeyCode.C))
            {
                gGame2 = true;
            }
        }

        if (gGame2 == true)
        {
            barrier2.SetActive(false);
            start4 = false;
            goodJob.SetActive(false);
            Time.timeScale = 1f;

        }


        if (start4)
        {

            milli += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.Space))
            {
                start4 = false;
                pGame2 = true;

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
        ////////////////////////////////////////////////////////////////////////////////

        if (pGame3 == true)
        {
            goodJob.SetActive(true);
            Time.timeScale = 0f;
            cGame3 = true;
        }


        if (cGame3 == true)
        {
            if (Input.GetKey(KeyCode.C))
            {
                gGame3 = true;

            }
        }

        if (gGame3 == true)
        {
            
            goodJob.SetActive(false);
           
            start5 = false;
            Time.timeScale = 1f;


        }

        if (start5)
        {
            stopSign.SetActive(true);
            milli += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.Space))
            {
                stopSign.SetActive(false);
                
                start5 = false;
                pGame3 = true;

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

            time.text = "00:00:00";

        }

        if (col.GetComponent<Collider>().tag == "Wall2")
        {
            stopSign.SetActive(true);
            start2 = true;


        }

        if (col.GetComponent<Collider>().tag == "Wall3")
        {
            if (!alreadyPlayed)
            {
                CarHorn.Play();
                alreadyPlayed = true;
            }

            barrier1.SetActive(true);

            start3 = true;

        }

        if (col.GetComponent<Collider>().tag == "Wall6")
        {
            if (!alreadyPlayed1)
            {
                tyreNoise.Play();
                alreadyPlayed1 = true;
            }

            barrier2.SetActive(true);

            start4 = true;


        }

        if (col.GetComponent<Collider>().tag == "Wall8")
        {
            
            start5 = true;


        }

        if (col.GetComponent<Collider>().tag == "Wall4")
        {
            reactText.text = "Reaction three";
            time.text = "00:00:00";
        }

        if (col.GetComponent<Collider>().tag == "Wall5")
        {
            reactText.text = "Reaction four";
            time.text = "00:00:00";
        }

        if (col.GetComponent<Collider>().tag == "Wall7")
        {
            reactText.text = "Reaction five";
            time.text = "00:00:00";
        }


    }

  
}
