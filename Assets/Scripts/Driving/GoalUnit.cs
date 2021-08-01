using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GoalUnit : MonoBehaviour
{
    public GoalUnit nextGoal;
    public bool ifWorking;
    public bool ifFinal;

    public SimulationManager simManager;
    public GoalManager goalManager;

    public Camera myCam;
    // Start is called before the first frame update
    private void Awake()
    {
        simManager = FindObjectOfType<SimulationManager>();
        goalManager = FindObjectOfType<GoalManager>();

        myCam = FindObjectOfType<XRRig>().cameraGameObject.GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(myCam.transform,Vector3.up);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("myCar") ) {

            if (ifWorking)
            {
                simManager.CreateHint("You reached one goal ");
                gameObject.SetActive(false);
                nextGoal.enabled = true;
                nextGoal.ifWorking = true;
            }
            else
            {
                simManager.CreateHint("You must reach previous goals first ");  
            }

            
            if (ifFinal)
            {
                simManager.CreateHint("Congratulations, You reached all your goal!");  
            }
        }

    }
}
