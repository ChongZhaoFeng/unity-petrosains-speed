using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEngine : MonoBehaviour
{

    public Transform path;
    public float maxSteerAngle = 90f;
    public float maxBrakeTorque = 150f;
    public bool isBraking = false;
    public float maxMotorTorque = 50f;
    //public static float currentSpeed;
    public WheelCollider WheelFL;
    public WheelCollider WheelFR;
    public WheelCollider WheelRL;
    public WheelCollider WheelRR;

    private List<Transform> nodes;
    private int currentNode = 0;

    // Start is called before the first frame update
    private void Start()
    {
      Transform[] pathTransforms = path.GetComponentsInChildren<Transform>();
      nodes = new List<Transform>();

      for(int i = 0; i< pathTransforms.Length; i++){
          if(pathTransforms[i] != path.transform) {
              nodes.Add(pathTransforms[i]);

          }
      }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        ApplySteer();
        Drive();
        CheckWayPointDistance();
        Braking();
    }

    private void ApplySteer() {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        relativeVector = relativeVector / relativeVector.magnitude;
        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;
        WheelFL.steerAngle = newSteer;
        WheelFR.steerAngle = newSteer;
        WheelRL.steerAngle = newSteer;
        WheelRR.steerAngle = newSteer;
    }

    private void Drive() {
        //currentSpeed = 2 * Mathf.PI * WheelFL.radius * wheelFL.rpm * 60 / 1000;

        //if (currentSpeed < maxSpeed && !isBraking)
             //{
                 WheelFL.motorTorque = maxMotorTorque;
                 WheelFR.motorTorque = maxMotorTorque;
                 WheelRR.motorTorque = maxMotorTorque;
                 WheelRL.motorTorque = maxMotorTorque;  
            // }
            // else
            // {
                // wheelFL.motorTorque = 0;
                // wheelFR.motorTorque = 0;
                // WheelRR.motorTorque = 0;
                // WheelRL.motorTorque = 0;  
           //  }
                       
    }

    private void CheckWayPointDistance() {
        if(Vector3.Distance(transform.position, nodes[currentNode].position)<0.5f){
            if(currentNode == nodes.Count - 1){
                currentNode = 0;
            }
            else{
                currentNode++;
            }
        }
    }

    private void Braking() {
        if (isBraking) {
            WheelFL.brakeTorque = maxBrakeTorque;
            WheelFR.brakeTorque = maxBrakeTorque;
            WheelRL.brakeTorque = maxBrakeTorque;
            WheelRR.brakeTorque = maxBrakeTorque;
        }
        else {
            WheelFL.brakeTorque = 0;
            WheelFR.brakeTorque = 0;
            WheelRL.brakeTorque = 0;
            WheelRR.brakeTorque = 0;
        }
    }

    void OnTriggerEnter(Collider col) {
         if(col.GetComponent<Collider>().tag == "Finish")
         {
            isBraking = true;

             
         }

		 

     }

}