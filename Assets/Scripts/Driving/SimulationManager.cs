using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SimulationManager : MonoBehaviour
{
    public GameObject[] Invoke;
    public ParticleSystem rainParticle;

    public Light myLight;
    public WheelCollider[] wheels;

    public Transform hintParent;
    public GameObject hint;
    public DataSave dataSave;

    public bool screenBool=true;
    public GameObject[] screens;
    

    public void Awake() {
        foreach (var obj in Invoke) {
            obj.SetActive(false);
        }

        Sunny_Start();
        CreateHint("Simulation Start");
        dataSave = FindObjectOfType<DataSave>();
    }

    public void StartSimulation() {
        foreach (var obj in Invoke) {
            obj.SetActive(true);
            
        } 
    }
    public void Sunny_Start()
    {
        rainParticle.Stop();
        myLight.intensity = 1f;
        
        foreach (var wheel in wheels) {
            wheel.wheelDampingRate=0.15f;
        }
        
        Debug.Log("Stop raining");
    }

    public void Sunny()
    {
        rainParticle.Stop();
        myLight.intensity = 1f;
        
        foreach (var wheel in wheels) {
            wheel.wheelDampingRate=0.15f;
        }

        dataSave.myData.Weather = "Sunny";
        CreateHint("Stop raining");
        Debug.Log("Stop raining");
    }
    
    public void Rainy()
    {
        rainParticle.Play(); 
        myLight.intensity = 0.5f;
        foreach (var wheel in wheels) {
            wheel.wheelDampingRate=0.08f;
        }
        
        dataSave.myData.Weather = "Rainy";
        CreateHint( "Start raining");
        Debug.Log("Start raining");
    }
    
    public void CreateHint(string _text)
    {
       var myHint= Instantiate(hint, hintParent);
       myHint.GetComponent<TextMeshProUGUI>().text = System.DateTime.Now.Hour+":"+System.DateTime.Now.Minute+":"+System.DateTime.Now.Second+"  "+_text;

       //Debug.Log(hintParent.childCount);
       if (hintParent.childCount > 4)
       {
           Destroy(hintParent.GetChild(0).gameObject);
       }
    }

    public void SimulationRestart()
    {
        SceneManager.LoadScene(0);
    }

    public void ToggleScreen()
    {
        if (screenBool)
        {
            foreach (var screen in screens)
            {
                screen.SetActive(false);
            }
        }
        
        else if (!screenBool)
        {
            foreach (var screen in screens)
            {
                screen.SetActive(true);
            }
        }
    }
}
