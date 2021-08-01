using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public GoalUnit lastUnit;
    public SimulationManager simManager; 
    public int currentNum;
    public int maxNum;

    public GameObject testGoals;
    public GameObject easyGoals;
    public GameObject difficultGoals;
    

    public void Awake()
    {
        currentNum = 1;
        simManager = FindObjectOfType<SimulationManager>();
    }

    public void Mode_Test()
    {
        testGoals.SetActive(true);
        simManager.CreateHint("Start test mode");
        maxNum = 4;

        simManager.dataSave.myData.Difficulty = "Test";
    }
    
    public void Mode_Easy()
    {
        easyGoals.SetActive(true);
        simManager.CreateHint("Start easy mode");
        maxNum = 8;
        
        simManager.dataSave.myData.Difficulty = "Easy";
    }
    
    public void Mode_Difficult()
    {
        difficultGoals.SetActive(true);
        simManager.CreateHint("Start difficult mode");
        maxNum = 12;
        
        simManager.dataSave.myData.Difficulty = "Difficult";
    }
}
