using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    public float hitCooldown = 3f;
    public SimulationManager simManager;

    private void Awake()
    {
        simManager = FindObjectOfType<SimulationManager>();
    }

    void Update()
    {
        if (hitCooldown > 0)
        {
            hitCooldown -= Time.deltaTime;

            if (hitCooldown < 0)
            {
                hitCooldown = 0;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (hitCooldown == 0 && !other.CompareTag("myCar"))
        {
            Debug.Log("You got hit by: "+other.gameObject.name);
            hitCooldown = 1.5f;
            simManager.CreateHint("You Got Hit !");
            simManager.dataSave.myData.hitTimes+=1;
        }
    }
}
