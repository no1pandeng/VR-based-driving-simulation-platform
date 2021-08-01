using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelFront : MonoBehaviour
{
    public GameObject[] myWheels;
    private Vector3 leftWheelPos;
    private Vector3 rightWheelPos;

    void Awake()
    {
        leftWheelPos=myWheels[0].transform.localPosition;
        rightWheelPos=myWheels[1].transform.localPosition;
    }

    void Update()
    {
        float yRotation = transform.eulerAngles.y;
        myWheels[0].transform.localPosition = leftWheelPos;
        myWheels[0].transform.eulerAngles = new Vector3(0f, yRotation, 90f);
        
        myWheels[1].transform.localPosition = rightWheelPos;
        myWheels[1].transform.eulerAngles = new Vector3(0f, yRotation, 90f);
    }
}
