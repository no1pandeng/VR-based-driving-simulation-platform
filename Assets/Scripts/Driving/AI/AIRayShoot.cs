using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class AIRayShoot : MonoBehaviour
{
    public float hitDistance;
    private Vector3 myDes;
    public bool ifStop;
    
    private Ray rayShoot;
    private RaycastHit hit;
    private NavMeshAgent myAgent;


    private void Awake()
    {
        myAgent = transform.parent.GetComponent<NavMeshAgent>();
    }

    private void Update() {
        Physics.Raycast(transform.position, transform.forward, out hit, hitDistance);

        if (hit.distance < hitDistance * 3f && hit.distance > 0.01f && hit.collider.CompareTag("Walking"))
        {
            Debug.DrawRay(transform.position, transform.forward, Color.blue);
            Pause();
        }
        else if (hit.distance<hitDistance && hit.distance>0.01f && !hit.collider.CompareTag("RoadTrigger")&& !hit.collider.CompareTag("Goal"))
        {
            Debug.DrawRay(transform.position, transform.forward, Color.red);
            Pause();
        }
        else
        {
            Resume();
        }

    }

    void Pause() {
        myAgent.isStopped = true;
        myAgent.speed = myAgent.speed * 0.8f;
    }

    void Resume() {
        myAgent.isStopped = false;
        if (myAgent.speed <= 0.3f)
        {
            myAgent.speed = 0.3f; 
        }

    }
    
}
