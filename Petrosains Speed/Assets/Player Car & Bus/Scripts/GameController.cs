using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float milli;
    public int sec;
    public int min;

    public float milli1;
    public int sec1;
    public int min1;

    public float milli2;
    public int sec2;
    public int min2;

    public float milli3;
    public int sec3;
    public int min3;

    public float milli4;
    public int sec4;
    public int min4;

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
    public GameObject Mission1;
    public GameObject missionBringBackAlive;
    public GameObject missionHorn;
    public GameObject missionskrtskrt;
    public GameObject missionCross;

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
            missionBringBackAlive.SetActive(true);
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
            missionBringBackAlive.SetActive(false);
            missionHorn.SetActive(true);
            stopSign.SetActive(false);
            goodJob.SetActive(false);
            carMove.SetActive(false);
            carMove1.SetActive(false);
            start2 = false;
            Time.timeScale = 1f;

            
        }


        if (start2)
        {
            
            milli1 += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.Space))
            {
                stopSign.SetActive(false);
                goodJob.SetActive(true);
                start2 = false;
                pGame = true;
                
            }

            if (milli1 >= 100)
            {
                milli1 = 0;
                sec1 += 1;
            }
            if (sec1 >= 60)
            {
                sec1 = 0;
                min1 += 1;
            }
            milliDisplay = "" + milli1.ToString("F1");

            if (sec1 < 10)
            {
                secDisplay = "0" + sec1.ToString();
            }
            else
            {
                secDisplay = sec1.ToString();
            }
            if (min1 < 10)
            {
                minDisplay = "0" + min1.ToString();
            }
            else
            {
                minDisplay = min1.ToString();
            }
            time.text = minDisplay + ":" + secDisplay + ":" + milliDisplay;


        }

        ////////////////////////////////////////////////////////////////////////////////////////

        if (pGame1 == true)
        {
            missionBringBackAlive.SetActive(true);
            goodJob.SetActive(true);
            Time.timeScale = 0f;
            cGame1 = true;
        }


        if (cGame1 == true)
        {
            if (Input.GetKey(KeyCode.C))
            {
                gGame1 = true;
                
            }
        }

        if (gGame1 == true)
        {
            missionskrtskrt.SetActive(true);
            barrier1.SetActive(false);
            start3 = false;
            goodJob.SetActive(false);
            
            Time.timeScale = 1f;

        }
       



        if (start3)
        {

            milli2 += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.Space))
            {
                start3 = false;
                pGame1 = true;

            }



            if (milli2 >= 100)
            {
                milli2 = 0;
                sec2 += 1;
            }
            if (sec2 >= 60)
            {
                sec2 = 0;
                min2 += 1;
            }
            milliDisplay = "" + milli2.ToString("F1");

            if (sec2 < 10)
            {
                secDisplay = "0" + sec2.ToString();
            }
            else
            {
                secDisplay = sec2.ToString();
            }
            if (min2 < 10)
            {
                minDisplay = "0" + min2.ToString();
            }
            else
            {
                minDisplay = min2.ToString();
            }
            time.text = minDisplay + ":" + secDisplay + ":" + milliDisplay;


        }

        ////////////////////////////////////////////////////////////////////////////////

        if (pGame2 == true)
        {
            missionskrtskrt.SetActive(false);
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
            Mission1.SetActive(true);
            missionBringBackAlive.SetActive(false);
            missionHorn.SetActive(false);
            missionskrtskrt.SetActive(false);
            barrier2.SetActive(false);
            start4 = false;
            goodJob.SetActive(false);
            Time.timeScale = 1f;

        }


        if (start4)
        {

            milli3 += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.Space))
            {
                start4 = false;
                pGame2 = true;

            }



            if (milli3 >= 100)
            {
                milli3 = 0;
                sec3 += 1;
            }
            if (sec3 >= 60)
            {
                sec3 = 0;
                min3 += 1;
            }
            milliDisplay = "" + milli3.ToString("F1");

            if (sec3 < 10)
            {
                secDisplay = "0" + sec3.ToString();
            }
            else
            {
                secDisplay = sec3.ToString();
            }
            if (min3 < 10)
            {
                minDisplay = "0" + min3.ToString();
            }
            else
            {
                minDisplay = min3.ToString();
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

            milli4 += Time.deltaTime * 100;

            if (Input.GetKey(KeyCode.Space))
            {
                stopSign.SetActive(false);
                
                start5 = false;
                pGame3 = true;

            }

            if (milli4 >= 100)
            {
                milli4 = 0;
                sec4 += 1;
            }
            if (sec4 >= 60)
            {
                sec4 = 0;
                min4 += 1;
            }
            milliDisplay = "" + milli4.ToString("F1");

            if (sec4 < 10)
            {
                secDisplay = "0" + sec4.ToString();
            }
            else
            {
                secDisplay = sec4.ToString();
            }
            if (min4 < 10)
            {
                minDisplay = "0" + min4.ToString();
            }
            else
            {
                minDisplay = min4.ToString();
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
            Mission1.SetActive(true);


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
