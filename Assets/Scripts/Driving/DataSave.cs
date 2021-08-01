using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSave : MonoBehaviour
{
    public string save_Folder;
    public MyData myData;
    public int saveNum=1;
 
    private void Awake()
    {
        save_Folder = Application.dataPath + "/SavedData/";
        myData=new MyData
        {
            TimeStart = "" + System.DateTime.Now,
            hitTimes = 0,
            Difficulty = "Unknown difficulty",
            Weather = "UnKnown Weather",
        };
    }

    public void Save()
    {
        string json = JsonUtility.ToJson(myData);
        myData.timeSpent = "" + System.DateTime.Now;
        
        while (File.Exists(save_Folder+"Data"+saveNum+".txt"))
        {
            saveNum ++;
        }
        File.WriteAllText(save_Folder+"Data"+saveNum+".txt",json);
        Debug.Log("Data Saved at:"+save_Folder+"Data"+saveNum+".txt");
        Debug.Log(json);
    }
}

public class MyData
{
    public string TimeStart;
    public string Difficulty;
    public string Weather;
    public string timeSpent;
    public int hitTimes;
}
