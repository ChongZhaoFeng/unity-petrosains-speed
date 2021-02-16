using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class PauseMenu : MonoBehaviour {
 
     bool Pause = false;
     public GameObject pauseMenuUI;
     public GameObject inGameUI;
     
     void Update()
     {
         
     if (Pause == false)
         {
             Time.timeScale = 1f;
         }
     else 
         {
             Time.timeScale = 0f;
         }
         
 
     if (Input.GetKeyDown(KeyCode.Escape))
         {
             if (Pause == true)
             {
                 Pause = false;
                 pauseMenuUI.SetActive(false);
                 inGameUI.SetActive(true);
             }
             
         else
             {
                 Pause = true;
                 pauseMenuUI.SetActive(true);
                 inGameUI.SetActive(false);
             }
         }
      
     
     }
 
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        inGameUI.SetActive(true);
        Pause = false;
    }
     
    public void LoadMenu()
    {
  
        Pause = false;
        SceneManager.LoadScene("MainMenu");

    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
 }
