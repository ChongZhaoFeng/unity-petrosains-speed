using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerEvent1 : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myTrigger.Invoke();
        }
        
    }
}
