
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputManager : MonoBehaviour{

    private PlayerAction myAction;

   
    public float vertical;
    public float horizontal;
    public bool handbrake;
    public float brakePower;
    public bool boosting;

    void Awake()
    {
        myAction=new PlayerAction();
    }

    public void MoveF(InputAction.CallbackContext ctx) 
    {
        vertical= ctx.ReadValue<float>();
        Debug.Log("Vertical= "+ vertical);
    }
    public void Brake(InputAction.CallbackContext ctx)
    {
        handbrake = true;
        float tempValue = ctx.ReadValue<float>();
        brakePower = tempValue*tempValue;
        
        if (brakePower == 0)
        {
            handbrake = false;
            Debug.Log("Break Up");
        }
        Debug.Log("Break force= "+brakePower);
    }
    public void TurnL(InputAction.CallbackContext ctx) 
    {
        float rotValue=Remap(ctx.ReadValue<float>(), -0.707f, 0.707f, -1f, 1f);
        horizontal = rotValue * -2.55f;
        Debug.Log("Horizontal= "+ horizontal);
    }
    
    public void TurnR(InputAction.CallbackContext ctx) 
    {
        float rotValue=Remap(ctx.ReadValue<float>(), -0.707f, 0.707f, -1f, 1f);
        horizontal = rotValue* 2.55f ;
        Debug.Log("Horizontal= "+ horizontal);
    }

    void Update()
    {

    }

    public void keyboard () {
        //vertical = Input.GetAxis ("Vertical");
        //horizontal = Input.GetAxis ("Horizontal");
        // handbrake = (Input.GetAxis ("Jump") != 0) ? true : false;
        //if (Input.GetKey (KeyCode.LeftShift)) boosting = true;
        //else boosting = false;

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
