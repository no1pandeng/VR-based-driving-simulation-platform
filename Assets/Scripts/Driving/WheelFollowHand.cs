using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR.Haptics;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using HapticCapabilities = UnityEngine.InputSystem.XR.Haptics.HapticCapabilities;
using InputDevice = UnityEngine.XR.InputDevice;
using XRController = UnityEngine.InputSystem.XR.XRController;

public class WheelFollowHand : MonoBehaviour
{
    public GameObject Hand;
    public GameObject wheel;
    public GameObject wheelUpC;
    public GameObject hold;
    public GameObject leftHand;
    public GameObject rightHand;
    private Vector3 wheelAxis;
    private Vector3 colliderPos;
    private bool leftControl;
    private bool rightControl;
    private Vector3 holdBegin;
    private Vector3 holdNow;
    private Vector3 wheelUp;
    private Vector3 handNow;
    private float steerHorizontal;
    private inputManager myInputManager;
    private XRManager myXRManager;
    [Header("Hold")]
    public bool ifHolding;

    
    public string  holdingHand;

    private void Awake()
    {
        wheelUp = wheel.transform.forward;
        handNow = wheelUp;
        wheelAxis = wheel.transform.up;
        colliderPos=Vector3.zero;
        myInputManager = FindObjectOfType<inputManager>();
        myXRManager = FindObjectOfType<XRManager>();
        holdingHand = "None";

    }

    void Update()
    {

        if (ifHolding) {
            Follow();
        }
    }

    void Follow()
    {
        if (holdingHand=="Right") {
            Hand.transform.position = rightHand.transform.position;
        }
        else if (holdingHand=="Left") {
            Hand.transform.position = leftHand.transform.position;
        }

        wheelAxis = wheelUpC.transform.up;
        Vector3 v3Diff = Hand.transform.position - wheel.transform.position;
        holdNow = Vector3.ProjectOnPlane(v3Diff.normalized, wheelAxis);

        float rotateAngle = Vector3.Angle(holdBegin, holdNow);
        Debug.Log("Rotate Angle= "+rotateAngle);
        if (rotateAngle > 1f) {
            Vector3 cross= Vector3.Cross(holdBegin, holdNow);
            if (Vector3.Dot(cross, wheelAxis) > 0) {
                //AntiClockWise
                handNow= Quaternion.AngleAxis(rotateAngle, wheelAxis) * -wheel.transform.up;
                wheel.transform.rotation = Quaternion.LookRotation(-wheelUpC.transform.up,-handNow);
                steerHorizontal += rotateAngle;
                
            }
            else {
                //ClockWise
                handNow= Quaternion.AngleAxis(-rotateAngle, wheelAxis) * -wheel.transform.up;
                wheel.transform.rotation = Quaternion.LookRotation(-wheelUpC.transform.up,-handNow);
                steerHorizontal -= rotateAngle;
            }
            myInputManager.horizontal = -1f*steerHorizontal/180f;
            Debug.Log("Steer Horizontal= "+ myInputManager.horizontal );
 
        }

        if (steerHorizontal > 180f||steerHorizontal < -180f)
        {
            float horizontalAbs = Mathf.Abs(steerHorizontal);
            float shakeLevel = Mathf.Clamp((horizontalAbs-180f)/180f,0f,1f);
            OutShake(holdingHand,shakeLevel);
            //Debug.LogWarning(holdingHand+" is SHAKING");

        }
        
        holdBegin = holdNow;

    }

    public void StartHold(SelectEnterEventArgs args)
    {
        Debug.Log(args.interactor.name);
        if (!ifHolding) {
            
            ifHolding = true;
            if (args.interactor.name=="RightBaseController") {
                holdBegin= (rightHand.transform.position-wheel.transform.position).normalized;
                holdNow = holdBegin;
                holdingHand = "Right";
                Debug.LogWarning("Start Holding Right!");
            }
            else if (args.interactor.name=="LeftBaseController") {
                holdBegin = (leftHand.transform.position-wheel.transform.position).normalized;
                holdNow = holdBegin;
                holdingHand = "Left";
                Debug.LogWarning("Start Holding Left!");
            }
            
            //holdBegin
        }
    }

    public void StopHolding(SelectExitEventArgs args)
    {
        if (ifHolding) {
            ifHolding = false;
            hold.transform.localPosition = Vector3.zero;
            holdingHand = "None";
            if (args.interactor.name=="RightBaseController") {
                Debug.LogWarning("Stop Holding Right!");
            }
            else if (args.interactor.name=="LeftBaseController") {
                Debug.LogWarning("Stop Holding Left!");
            }

        }
    }

    public void OutShake(string hand,float outValue)
    {
        if (hand == "Right")
        {
            InputDevice rightHand=InputDevices.GetDeviceAtXRNode(XRNode.RightHand); 
            rightHand.SendHapticImpulse(0, outValue, 0.1f);
        }
        else if (hand == "Left")
        {
            InputDevice leftHand=InputDevices.GetDeviceAtXRNode(XRNode.LeftHand); 
            leftHand.SendHapticImpulse(0, outValue, 0.1f);
        }

    }
    
    
}
