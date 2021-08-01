using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class SelfDriving : MonoBehaviour
{
    private NavMeshAgent myAgent;
    public bool ifClockWise;

    public bool ifAutoMode = true;
    public float minSpeed=0.3f;
    public float maxSpeed = 2.5f;
    private float _acce;
    
    private void Awake() {
        myAgent = GetComponent<NavMeshAgent>();
        _acce = myAgent.acceleration;

        myAgent.velocity = Vector3.zero;


    }

    private void Update()
    {
        minSpeed = SelfDrivingManager.minSpeed;
        maxSpeed = SelfDrivingManager.maxSpeed;
        
        if (myAgent.velocity.magnitude>0.25f)
        {
            Vector3 dir = myAgent.destination - transform.position;
            float angle = Vector3.Angle(dir,myAgent.transform.forward);

            if (myAgent.speed < maxSpeed)
            {
                myAgent.speed+= 0.3f * Time.deltaTime;
            }

            /*if (angle>50f && !myAgent.isStopped) {
                AdjustDirection_Large();
            }
            else if (angle>20f && !myAgent.isStopped) {
                AdjustDirection();
            } */
        }

    }

    public void MoveToClick(InputAction.CallbackContext ctx) {

        if (ifAutoMode) {
            Camera cam=Camera.main;
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                   
            if (Physics.Raycast(ray, out hit)) {
                Transform objectHit = hit.transform;

                if (hit.collider.transform.parent.name == "ClockWise" && ifClockWise) {
                    myAgent.destination = hit.point;
                }
                else if (hit.collider.transform.parent.name == "AntiClockWise" && !ifClockWise) {
                    myAgent.destination = hit.point;  
                }

                // Do something with the object that was hit by the raycast.
            }

                   
            //Debug.Log(gameObject.name+" will go to: "+ hit.point); 
        }
    }

    public void AdjustDirection_Large()
    {
        float nowSpeed = myAgent.velocity.magnitude;
        Vector3 targetDir = myAgent.destination - myAgent.transform.position;

        Vector3 newDir =(0.2f*myAgent.transform.forward+targetDir).normalized;
        Vector3 newVelocity =(nowSpeed) * newDir;
        myAgent.velocity = newVelocity;
        
    }
    public void AdjustDirection()
    {
        float nowSpeed = myAgent.velocity.magnitude;

        if (nowSpeed < minSpeed) {
            nowSpeed = minSpeed;
        }

        Vector3 newDir =(3f*myAgent.transform.forward+myAgent.velocity).normalized;
        Vector3 newVelocity =nowSpeed * newDir;
        myAgent.velocity = newVelocity;
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("RoadTrigger"))
        {
            Transform transform = other.GetComponent<RoadTrigger>().targetTrigger.transform;
            myAgent.destination = transform.position;
            //Debug.Log("AI car go to: "+other.gameObject.name);
        }
    }
}
