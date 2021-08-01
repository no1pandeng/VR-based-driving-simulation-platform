using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class SelfDrivingManager : MonoBehaviour
{

    public static float minSpeed=0.65f;
    public static float maxSpeed=5f;

    public float mixSpeedDisplay;
    public float maxSpeedDisplay;

    public TextMeshProUGUI min_TMP;
    public TextMeshProUGUI max_TMP;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mixSpeedDisplay = minSpeed;
        maxSpeedDisplay = maxSpeed;
    }

    public void ChangeMin(float _min)
    {
        minSpeed = _min;
        min_TMP.text = _min.ToString("F1");
    }
    
    public void ChangeMax(float _max)
    {
        maxSpeed = _max;
        max_TMP.text = _max.ToString("F1");
    }
}
