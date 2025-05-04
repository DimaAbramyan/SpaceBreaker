using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class AllSaves : MonoBehaviour
{
    public static AllSaves instance;
    public SaveData[] AllSavesThatLoaded;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public AllSaves()
    {
        AllSavesThatLoaded = new SaveData[3];
    }
}
