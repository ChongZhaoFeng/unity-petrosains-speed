using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameProgression : MonoBehaviour
{

    public string lvlname;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


	 void OnCollisionEnter(Collision exampleCol) {
         if(exampleCol.collider.tag == "Wall")
         {
             //Replace 'Game Over' with your game over scene's name.
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);

         }
     }






	void OnTriggerEnter(Collider col) {
         if(col.GetComponent<Collider>().tag == "Finish")
         {
             //Replace 'Game Over' with your game over scene's name.
			 SceneManager.LoadScene(lvlname);
             


             
         }


		 

     }




}
