using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCar : MonoBehaviour
{

    [SerializeField] private GameObject myCar;

    public void ActivateAICar()
    {
        myCar.SetActive(false);
    }
}
