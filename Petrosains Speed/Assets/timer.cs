 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class timer : MonoBehaviour {
 
     public Text counterText;
     public bool TimerOn;
     public float seconds, minutes;
 
     void Start(){
         TimerOn = false;
         Text counterText = GetComponent<Text>();
         counterText = GetComponent<Text>() as Text;
     }
 
     void Update(){
         counterText.text = "00" + ":" + "00";

     }



      void OnTriggerEnter (Collider other) {
      if (other.gameObject.CompareTag("Start")) {
            TimerOn = true;
            minutes = (int)(Time.time / 60f);
            seconds = (int)(Time.time % 60f);
            counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

      } else if (other.gameObject.CompareTag("Finish")) {
           TimerOn = false;
      }
 }
 }
