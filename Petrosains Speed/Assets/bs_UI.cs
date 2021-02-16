using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bs_UI : MonoBehaviour
{

    public GameObject UI;
    public GameObject UI2;
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
        UI.SetActive(false);
        

    }

    public void back()
    {
        UI2.SetActive(true);
    }
     

}
