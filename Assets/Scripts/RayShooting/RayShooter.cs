using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    public float maxDistance=2f;
    public string warning;
    private Ray rayShoot;
    private RaycastHit hit;
    private Vector3 rayDirection;
    private RayShootingManager rayManager;

    private void Start() {
        rayDirection = transform.forward;
        rayManager = FindObjectOfType<RayShootingManager>();

    }

    void FixedUpdate()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;
        
        // Does the ray intersect any objects excluding the player layer
        
        /*if (Physics.Raycast(transform.position, rayDirection, out hit, maxDistance, layerMask)) {
            Debug.DrawRay(transform.position, rayDirection* hit.distance, Color.red);
            //Debug.Log("Did Hit");
        }*/
        Physics.Raycast(transform.position, rayDirection, out hit, maxDistance);

        if (hit.distance >= 3f) {
            Debug.DrawRay(transform.position, rayDirection, Color.white);
            //2f
        }
        else if (hit.distance >= 1.5f) {
            Debug.DrawRay(transform.position, rayDirection, Color.yellow);
            //2f
        }
        else if (hit.distance >= 1f) {
            Debug.DrawRay(transform.position, rayDirection, Color.red);
            //2f
        }
        else if (hit.distance >= 0.4f) {
            Debug.DrawRay(transform.position, rayDirection, Color.black);
            //2f
        }
        else if (!hit.collider)
        {
            Debug.DrawRay(transform.position, rayDirection, Color.green);
        }

        if (hit.collider&& hit.distance < 4f ) {
            
            if (!hit.collider.CompareTag("myCar")) {
                rayManager.TryWarning(hit.distance);
                Debug.Log("My car hit: "+hit.distance+" "+gameObject.name); 
            }

        }
    }
}
