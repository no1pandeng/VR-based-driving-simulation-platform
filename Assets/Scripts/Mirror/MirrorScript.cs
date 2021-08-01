using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorScript : MonoBehaviour
{
    public GameObject Eye;
    public GameObject MirrorCenter;
    public Camera MirrorCam;

    private void Update()
    {
        Vector3 viewVector = MirrorCenter.transform.position - Eye.transform.position;
        Vector3 mirrorVector = MirrorCenter.transform.forward * -1f;

        Vector3 viewProjection = Vector3.Project(viewVector, mirrorVector);

        MirrorCam.transform.position = Eye.transform.position + 2f * viewProjection;
        MirrorCam.transform.LookAt(MirrorCenter.transform);
    }
}
