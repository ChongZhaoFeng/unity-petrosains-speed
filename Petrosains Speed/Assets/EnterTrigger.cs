using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{
  private void onTriggerEnter(Collider other){
      if (other.CompareTag("Player")){
          print("Working");
      }
  }
}
