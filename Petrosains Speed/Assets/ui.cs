using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{

    public GameObject disableGame;
    public GameObject UI2;
    // Start is called before the first frame update


    void Start(){
     disableGame.GetComponent<GameController>().enabled = false;
    

    }

    // Update is called once per frame
    void Update(){

        

    }

    public void close()
    {
        
        UI2.SetActive(true);
    }
     
}
