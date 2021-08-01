using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public WheelCollider[] wheels;
    public GameObject[] wheelVisual;
    private bool ifPowered;
    public float totalPower;
    public Rolling myRolling;
    public GameObject massOfCenter;
    private float horizontal;
    private float horizontal_Input;
    private Vector3 wheelPosition;
    private Quaternion wheelRotation;
    private Rigidbody myRb;

    public void Awake()
    {
        myRolling=new Rolling();
        myRb = GetComponent<Rigidbody>();
        myRb.centerOfMass = massOfCenter.transform.localPosition;
    }

    public void Update()
    {
        PowerManager();
        WheelsManager();
    }

    public void MoveF(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() != 0)
        {
            ifPowered = true;   
        }
        else
        {
            ifPowered = false;    
            Debug.Log("Stop engine");
        }

    }

    public void PowerManager()
    {
        /*for (int i = 0; i < wheels.Length; i++) {
            if (ifPowered) {
                wheels[0].motorTorque = totalPower/wheels.Length; 
            }
            else {
                wheels[i].motorTorque = 0;  
            }
        }*/
        if (ifPowered) {
            wheels[0].motorTorque = totalPower/wheels.Length; 
            wheels[1].motorTorque = totalPower/wheels.Length; 
        }
        else {
            wheels[0].motorTorque = 0;  
            wheels[1].motorTorque = 0;  
        }
    }
    public void WheelsManager()
    {
        horizontal = Mathf.Lerp(horizontal , horizontal_Input , (horizontal_Input != 0) ? 2 * Time.deltaTime : 6 * 2 * Time.deltaTime);
        Debug.Log(horizontal);
        
        if (horizontal > 0) {
            wheels[0].steerAngle = Mathf.Rad2Deg * Mathf.Atan(1.6f) * horizontal; 
            wheels[1].steerAngle = Mathf.Rad2Deg * Mathf.Atan(1.4f) * horizontal; 
        }
        else if (horizontal < 0){
            wheels[0].steerAngle = Mathf.Rad2Deg * Mathf.Atan(1.6f) * horizontal; 
            wheels[1].steerAngle = Mathf.Rad2Deg * Mathf.Atan(1.4f) * horizontal; 
        }
        
        
        //loop update pos and rot
        for (int i = 0; i < wheels.Length; i++) {
            wheels[i].GetWorldPose(out wheelPosition, out wheelRotation);
            wheelVisual[i].transform.position = wheelPosition;
            wheelVisual[i].transform.rotation = wheelRotation;
        }
    }

    public void Brake(InputAction.CallbackContext ctx)
    {
        
    }

    public void RotateLeft(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() != 0)
        {
            horizontal_Input = -1f;
        }
        else
        {
            horizontal_Input = 0f;
        }
 
    }
    public void RotateRight(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() != 0)
        {
            horizontal_Input = 1f;
        }
        else
        {
            horizontal_Input = 0f;
        }
    }
    
    public void Jump()
    {
        transform.position += 1f * Vector3.up;
    }
    
    public void Jump_New(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
            Debug.Log("Action was started");
        /*else if (ctx.performed)
            Debug.Log("Action was performed");
        else if (ctx.canceled)
            Debug.Log("Action was cancelled");*/
    }
    
}
