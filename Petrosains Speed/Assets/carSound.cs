using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSound : MonoBehaviour
{


    AudioSource audioSource;
    public float minPitch = 0.05f;
    public float maxPitch = 0.8f;
    private float pitchFromCar;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = minPitch ;     

    }

    // Update is called once per frame
    void Update()
    {
        pitchFromCar = (LPPV_CarController.cc.carSpeed)/5;

        
        if(pitchFromCar < minPitch)
            audioSource.pitch = minPitch;

        else if (pitchFromCar > maxPitch)
            audioSource.pitch = maxPitch;

        else audioSource.pitch = pitchFromCar;
        
    }
}
