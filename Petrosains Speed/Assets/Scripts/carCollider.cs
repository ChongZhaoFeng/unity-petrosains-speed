using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carCollider : MonoBehaviour
{


     void OnTriggerEnter(Collider other)
 {
     if (other.tag == "Player")
     {
         GameObject.Find("First Person View").GetComponent<CameraSwitch>().enabled = true;

     }
 }
 
 void OnTriggerExit(Collider other)
 {
     if (other.tag == "Player")
     {
         GameObject.Find("First Person View").GetComponent<CameraSwitch>().enabled = false;

     }
 }
}
