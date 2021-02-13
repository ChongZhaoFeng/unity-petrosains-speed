using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uistartgame : GameController
{
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;
    public GameObject go5;

   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void close()
    {
        StartCoroutine(go5.GetComponent<GameController>().CountDown());
        go4.GetComponent<GameController>().enabled = true;
        go1.SetActive(false);
        go2.SetActive(false);
        go3.SetActive(false);
    }
}
