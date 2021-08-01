using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool ifLeftSelect;
    public bool ifRightSelect;

    private void Awake()
    {
        ifLeftSelect = false;
        ifRightSelect = false;
    }

    public void leftSelect()
    {
        if (ifRightSelect)
        {
            ifRightSelect= false;
        } 
        ifLeftSelect = true;

        Debug.LogWarning("LEFT SELECTED");
    }

    public void rightSelect()
    {
        if (ifLeftSelect)
        {
            ifLeftSelect= false;
        } 
        ifRightSelect = true;
        //Debug.LogWarning("RIGHT SELECTED");
    }

}
