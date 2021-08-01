using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeMove : MonoBehaviour
{
    private PlayerAction myAction;
    private Rigidbody myWheelRB;
    private PhysicMaterial myCarMaterial;
    public SteeringWheel mySteeringWheel;
    public WheelFront myWheel;
    public float rotateFactor;
    [SerializeField] private float speedForward;
    [SerializeField] private float forceForward;
    [SerializeField] private float rotateAngle;

    private void Awake() 
    {
        myAction=new PlayerAction();
        myWheelRB = myWheel.GetComponent<Rigidbody>();
        myCarMaterial = GetComponent<BoxCollider>().material;

    }

    void Update() 
    {
        MovingFunctions();
        Turn();
    }

    private void MovingFunctions() 
    {
        //Move forward
        Vector3 forwardDir = myWheel.transform.forward;
        
        myWheelRB.AddForce(50f*forceForward*forwardDir);

    }
    
    public void MoveF(InputAction.CallbackContext ctx) 
    {
        forceForward= ctx.ReadValue<float>();
        Debug.Log("Force= "+ forceForward);
    }

    public void Break(InputAction.CallbackContext ctx)
    {
        float breakInput=Mathf.Pow(ctx.ReadValue<float>(),3)*12f;
        if (breakInput < 0.2f)
        {
            breakInput = 0.2f;
        }
        myCarMaterial.dynamicFriction= breakInput;
        Debug.Log("Break= "+ myCarMaterial.dynamicFriction);
    }

    void Turn()
    {
        mySteeringWheel.transform.eulerAngles = new Vector3(0, 0, -rotateAngle);
        myWheel.transform.eulerAngles=new Vector3(0,rotateAngle*rotateFactor,0f);

    }
    
    public void TurnL(InputAction.CallbackContext ctx) 
    {
        float rotValue=Remap(ctx.ReadValue<float>(), -0.707f, 0.707f, -1f, 1f);
        rotateAngle = rotValue * 90f*-1f;
        Debug.Log("L rotateAngle= "+ rotateAngle);
    }
    
    public void TurnR(InputAction.CallbackContext ctx) 
    {
        float rotValue=Remap(ctx.ReadValue<float>(), -0.707f, 0.707f, -1f, 1f);
        rotateAngle = rotValue * 90f;
        Debug.Log("R rotateAngle= "+ rotateAngle);
    }


    
    public static float Remap ( float from, float fromMin, float fromMax, float toMin,  float toMax)
    {
        var fromAbs  =  from - fromMin;
        var fromMaxAbs = fromMax - fromMin;      
       
        var normal = fromAbs / fromMaxAbs;
 
        var toMaxAbs = toMax - toMin;
        var toAbs = toMaxAbs * normal;
 
        var to = toAbs + toMin;
       
        return to;
    }
    
}
