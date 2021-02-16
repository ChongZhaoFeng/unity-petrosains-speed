using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu1 : MonoBehaviour
{

    bool Pause = false;
    public GameObject pauseMenuUI1;
    public GameObject inGameUI1;

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
                pauseMenuUI1.SetActive(false);
                inGameUI1.SetActive(true);
            }

            else
            {
                Pause = true;
                pauseMenuUI1.SetActive(true);
                inGameUI1.SetActive(false);
            }
        }


    }

    public void Resume()
    {
        pauseMenuUI1.SetActive(false);
        inGameUI1.SetActive(true);
        Pause = false;
    }

    public void LoadMenu()
    {

        Pause = false;
        SceneManager.LoadScene("MainMenu");

    }

    public void QuitGame()
    {
        Pause = false;
        SceneManager.LoadScene("ReactionTime");
    }
}
