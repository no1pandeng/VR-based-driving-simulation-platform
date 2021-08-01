using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShootingManager : MonoBehaviour
{
    public RayShooter[] RayShooters;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public bool ifWarning;
    public float warnClose = 1.5f;
    public float warnDistance;
    public float warnDistanceTemp;


    private void Awake()
    {
        RayShooters=FindObjectsOfType<RayShooter>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (warnDistance<warnClose) {
            ifWarning=true;

        }
        else {
            ifWarning=false; 
            audioSource.Stop();
        }

        if (ifWarning) {
            RayWarning();
            if (!audioSource.isPlaying) {
                audioSource.Play();
            }
        }
        else {
            if (audioSource.isPlaying) {
                audioSource.Stop();
            }
        }
    }
    

    void RayWarning() {

        float warnLevel = 1f;
        if (warnDistance < warnClose) {
            warnLevel = 1.5f-warnDistance*0.333f;

            if (warnLevel > 1.5f)
            {
                warnLevel = 1.5f;
            }
        }

        audioSource.pitch = warnLevel;
    }

    public void TryWarning(float _dis) {
        if (_dis < warnDistanceTemp) {
            warnDistanceTemp = _dis;
        }
    }

    public void LateUpdate()
    {
        if (warnDistanceTemp<warnClose)
        {
            warnDistance = warnDistanceTemp;
        }
        else
        {
            warnDistance = 1+warnClose;
        }

        warnDistanceTemp = warnClose;
    }
}
