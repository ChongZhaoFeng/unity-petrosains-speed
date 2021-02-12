using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bs_difficultyselection : MonoBehaviour
{


    
    

    // Start is called before the first frame update
    public void ChangeSceneEasy(Button button)
    {
             print(button.name);
            if (button.name == "Easy"){

             

            
            SceneManager.LoadScene("BlindSpotS1");
            Destroy(GetComponent<gameProgression>());
            
             }

        
    }


}
