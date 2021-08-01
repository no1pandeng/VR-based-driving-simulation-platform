using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public float timeLast=5f;

    private void Update()
    {
        if (timeLast > 0f)
        {
            timeLast -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
